using CodingChallenge.classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CodingChallenge
{

    public partial class Main : Form
    {
        private List<KeyValuePair<int, List<Hardware>>> _hardwareFinal = new List<KeyValuePair<int, List<Hardware>>>();
        private List<Hardware> _hardwareOriginal = new List<Hardware>();
        private List<Hardware> _hardware = new List<Hardware>();
        private List<Truck> _trucks = new List<Truck>();
        private RootObject _root = new RootObject();


        /// <summary>
        ///     Initialize the form
        /// </summary>
        public Main()
        {
            InitializeComponent();
            PreloadDisplay();
        }


        /// <summary>
        ///     Preloads the dataGridView
        /// </summary>
        private void PreloadDisplay()
        {
            _ = DataDisplay.Columns.Add("Truck", "Transporter");
            _ = DataDisplay.Columns.Add("Name", "Name");
            _ = DataDisplay.Columns.Add("Amount", "Menge");
            _ = DataDisplay.Columns.Add("Weight", "Gesamt Gewicht");
            _ = DataDisplay.Columns.Add("Priority", "Nutzwert");

            foreach (DataGridViewColumn column in DataDisplay.Columns)
            {
                column.Width = 90;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        /// <summary>
        ///     Loads the dataGridView with all data
        /// </summary>
        private void LoadDisplay()
        {
            DataDisplay.Rows.Clear();

            _hardwareFinal.ForEach((keyValuePair) =>
            {
                Truck t = _trucks[keyValuePair.Key];
                int sumWeight = 0;

                keyValuePair.Value.ForEach(h =>
                {
                    Hardware originalH = _hardwareOriginal.Find(hF => hF.Name == h.Name);

                    _ = DataDisplay.Rows.Add(
                        t.Name,
                        h.Name,
                        h.Amount.ToString() + " Stk. von " + originalH.Amount.ToString() + " Stk.",
                        ToKG(h.GetRealWeight()) + " von " + ToKG(originalH.GetRealWeight()),
                        originalH.Priority
                    );

                    sumWeight += h.GetRealWeight();
                });

                int row = DataDisplay.Rows.Add("Transporter Gewicht:", ToKG(sumWeight), "von", ToKG(GetTruckMaxWeight(t)), "belegt");
                DataDisplay.Rows[row].DefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
                _ = DataDisplay.Rows.Add("", "", "", "");
            });

            int leftSumWeight = 0;
            int leftSumAmount = 0;

            _hardware.ForEach(h =>
            {
                Hardware originalH = _hardwareOriginal.Find(hF => hF.Name == h.Name);

                _ = DataDisplay.Rows.Add(
                    "Übrig",
                    h.Name,
                    h.Amount.ToString() + " Stk. von " + originalH.Amount.ToString() + " Stk.",
                    ToKG(h.GetRealWeight()) + " von " + ToKG(originalH.GetRealWeight()),
                    h.Priority
                );

                leftSumWeight += h.GetRealWeight();
                leftSumAmount += h.Amount;
            });

            int rowEnd = DataDisplay.Rows.Add("", "Insgesamt übrig:", leftSumAmount.ToString() + " Stk.", ToKG(leftSumWeight));
            DataDisplay.Rows[rowEnd].DefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
        }


        /// <summary>
        ///     Converts kg int to kg string
        /// </summary>
        /// <param name="kg">
        ///     int | kg
        /// </param>
        /// <returns>
        ///     string | kg as string
        /// </returns>
        private static string ToKG(int kg) => ((float)kg / 1000).ToString("0.00") + "kg";


        /// <summary>
        ///     Calculates the real maximal truck weight
        /// </summary>
        /// <param name="t">
        ///     Truck | the truck object
        /// </param>
        /// <returns>
        ///     int | real max weight
        /// </returns>
        private int GetTruckMaxWeight(Truck t) => t.MaxWeight - ((t.DriverWeight[0] + t.DriverWeight[1]) / 2);


        /// <summary>
        ///     Starts to run the "Greedy Algorithm" with "Knapsack Problem" method & 
        ///     three trires "Fractional Knapsack Problem" method
        /// </summary>
        /// <exception cref="Exception">
        ///     Shows an exception in the console if the algorithm doesn't work
        /// </exception>
        private void RunAlgorithmus()
        {
            try
            {
                List<Hardware> left = new List<Hardware>();
                int averagePriority = (_hardware.Min(h => h.Priority) + _hardware.Max(h => h.Priority)) / 2;
                int current = 0;

                _hardware.ForEach(h =>
                {
                    if (h.Priority < averagePriority)
                    {
                        int devided = h.Amount / _hardware.Count;
                        left.Add(CopyHardware(h, h.Amount - devided));
                        _hardware[current].Amount = devided;
                    }

                    current++;
                });

                _hardware.Sort((first, next) => first.Priority.CompareTo(next.Priority));
                current = 0;

                _trucks.ForEach((truck) =>
                {
                    int truckRealMaxWeight = GetTruckMaxWeight(truck);
                    List<Hardware> result = RunKnapsackMethod(truckRealMaxWeight, _hardware);
                    List<Hardware> addToFinal = new List<Hardware>();

                    result.ForEach(h =>
                    {
                        _hardware.RemoveAt(_hardware.FindIndex(hf => hf.Name == h.Name));
                        addToFinal.Add(h);
                    });

                    int filled, tried = 0;
                    while ((filled = addToFinal.Sum(h => h.GetRealWeight())) <= truckRealMaxWeight)
                    {
                        RunFractionalKnapsackMethod(truckRealMaxWeight - filled, _hardware).ForEach(h =>
                        {
                            if (h.Amount != 0)
                            {
                                int index = _hardware.FindIndex(hf => hf.Name == h.Name);
                                if (_hardware[index].Amount != h.Amount)
                                {
                                    _hardware[index].Amount = _hardware[index].Amount - h.Amount;
                                }
                                else
                                {
                                    _hardware.RemoveAt(index);
                                }

                                addToFinal.Add(h);
                            }
                        });

                        _ = _hardware.OrderBy(h => h.Weight);

                        if (tried > 10)
                        {
                            break;
                        }

                        tried++;
                    }

                    _hardwareFinal.Add(new KeyValuePair<int, List<Hardware>>(current, addToFinal));
                    _hardware.Sort((first, next) => first.Priority.CompareTo(next.Priority));

                    current++;
                });

                left.ForEach(h =>
                {
                    int index = _hardware.FindIndex(hf => hf.Name == h.Name);
                    if (index == -1)
                    {
                        _hardware.Add(h);
                    }
                    else
                    {
                        _hardware[index].Amount = _hardware[index].Amount + h.Amount;
                    }
                });

                LoadDisplay();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while running algorithm: " + ex.ToString());
            }
        }


        /// <summary>
        ///     Runs the "Knapsack Problem" method with hardware weight & amount
        /// </summary>
        /// <param name="maxWeight">
        ///     int | Maximal weight for knapsack
        /// </param>
        /// <param name="h">
        ///     List<Hardware> | Current available hardware
        /// </param>
        /// <returns>
        ///     List<Hardware>
        /// </returns>
        private static List<Hardware> RunKnapsackMethod(int maxWeight, List<Hardware> h)
        {
            int i, w, n = h.Count, W = maxWeight;
            int[,] K = new int[n + 1, W + 1];
            List<Hardware> hardware = new List<Hardware>();

            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                    {
                        K[i, w] = 0;
                    }
                    else if (h[i - 1].GetRealWeight() <= w)
                    {
                        K[i, w] = Math.Max(h[i - 1].Amount + K[i - 1, w - h[i - 1].GetRealWeight()], K[i - 1, w]);
                    }
                    else
                    {
                        K[i, w] = K[i - 1, w];
                    }
                }
            }

            int res = K[n, W];

            w = W;
            for (i = n; i > 0 && res > 0; i--)
            {
                if (res == K[i - 1, w])
                {
                    continue;
                }
                else
                {
                    hardware.Add(CopyHardware(h[i - 1]));
                    res -= h[i - 1].Amount;
                    w -= h[i - 1].GetRealWeight();
                }
            }

            return hardware;
        }


        /// <summary>
        ///     Runs the "Fractional Knapsack Problem" method with hardware weight & amount
        ///     It also splits the hardware amount in fractionals
        /// </summary>
        /// <param name="maxWeight">
        ///     int | Maximal weight for knapsack
        /// </param>
        /// <param name="h">
        ///     List<Hardware> | Current available hardware
        /// </param>
        /// <returns>
        ///     List<Hardware>
        /// </returns>
        private static List<Hardware> RunFractionalKnapsackMethod(int maxWeight, List<Hardware> h)
        {
            int W = maxWeight, n = h.Count;
            List<Hardware> hardware = new List<Hardware>();

            h.Sort((Hardware a, Hardware b) =>
            {
                return (b.Amount / b.GetRealWeight()).CompareTo(a.Amount / a.GetRealWeight());
            });

            int curWeight = 0;
            double finalvalue = 0.0;

            for (int i = 0; i < n; i++)
            {
                Hardware oldH = h[i];

                if (curWeight + oldH.GetRealWeight() <= W)
                {
                    curWeight += oldH.GetRealWeight();
                    finalvalue += oldH.Amount;

                    hardware.Add(CopyHardware(oldH));
                }
                else
                {
                    int remain = W - curWeight;
                    float amount = oldH.Amount * ((float)remain / oldH.GetRealWeight());
                    int newWeight = (int)amount * oldH.Weight; 

                    if (curWeight + newWeight <= W)
                    {
                        finalvalue += amount;
                        curWeight += newWeight;
                        hardware.Add(CopyHardware(oldH, (int)amount));
                    }
                }
            }

            return hardware;
        }


        /// <summary>
        ///     Deep copys a hardware object
        /// </summary>
        /// <param name="h">
        ///     Hardware | the hardware object
        /// </param>
        /// <param name="amount">
        ///     int? | hardware amount
        /// </param>
        /// <returns>
        ///     Hardware | Deep copied hardware object
        /// </returns>
        private static Hardware CopyHardware(Hardware h, int? amount = null)
        {
            return new Hardware
            {
                Name = h.Name,
                Amount = amount == null ? h.Amount : (int)amount,
                Priority = h.Priority,
                Weight = h.Weight
            };
        }


        /// <summary>
        ///     Loads the objects from the JSON string in the lists
        /// </summary>
        /// <param name="json">
        ///     string | JSON as string
        /// </param>
        /// <exception cref="Exception">
        ///     Shows an exception in the console if the JSON could not be loaded
        /// </exception>
        private void LoadJSON(string json)
        {
            try
            {
                _root = JsonConvert.DeserializeObject<RootObject>(json);
                _hardwareOriginal = JsonConvert.DeserializeObject<RootObject>(json).Hardware; //Deep clone

                _hardware = _root.Hardware;
                _trucks = _root.Trucks;

                RunAlgorithmus();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while JSON parsing: " + ex.ToString());
            }
        }


        /// <summary>
        ///     Event that runs when the user clicks on the 'Daten auswählen (als JSON)' button
        /// </summary>
        private void SelectJSON_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "JSON file|*.json",
                FilterIndex = 0,
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true
            })
            {
                DialogResult check = fileDialog.ShowDialog();
                if (check == DialogResult.OK)
                {
                    string fileName = fileDialog.FileName;
                    if (fileName.Trim() == string.Empty)
                    {
                        return;
                    }

                    using (StreamReader r = new StreamReader(fileName))
                    {
                        LoadJSON(r.ReadToEnd());
                    }
                }
            }
        }

        /// <summary>
        ///     Closes the application
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///     DataGridView event to remove selection color
        /// </summary>
        private void DataDisplay_SelectionChanged(object sender, EventArgs e)
        {
            DataDisplay.ClearSelection();
        }
    }
}