using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salesman_tour
{
    public partial class MainForm : Form
    {
        // FIELDS
        Graphics graphic;
        GraphicsState mapState;
        Pen CityRedPen;
        Pen CityBluePen;
        Pen WayBlackPen;
        Pen HomeWayGreenPen;
        Pen PossibleCityBluePen;
        Pen ChoosenCityBlackPen;


        int delay;
        bool isGenerated;
        bool run;

        int maxGeneration;
        int currentGeneration;

        string DoubleNumberFormat;

        int lookAtPrevCityIndex;
        int lookAtCurrentCityIndex;


        Population salesmen;
        CityModel.City[] Cities;

        // PROPERTIES
        int CurrentGeneration
        {
            get
            {
                return currentGeneration;
            }
            set
            {
                currentGeneration = value;
                GenerationToolStripStatusLabel.Text = String.Format("generation = {0}", currentGeneration);
            }
        }
        int Delay
        {
            set
            {
                delay = value * 100;
            }
        }
        int StartCityIndex
        {
            get
            {
                // -1 cus index start with 0
                return (int)StartCityUpDown.Value - 1;
            }
            set
            {
                StartCityUpDown.Value = value + 1;
            }
        }
        int CityAmount
        {
            get
            {
                return CityTrackBar.Value;
            }
            set
            {
                CityTrackBar.Value = value;
                VisibleCityAmountLbl.Text = CityTrackBar.Value.ToString();
                CityToolStripStatusLabel.Text = "city = " + CityTrackBar.Value.ToString();
            }
        }
        // FORM
        public MainForm()
        {
            InitializeComponent();
            DistanceToolStripStatusLabel.Text = String.Empty;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            graphic = Map.CreateGraphics();
            CityRedPen = new Pen(color: Color.Red, width: 3);
            CityBluePen = new Pen(color: Color.Blue, width: 3);
            WayBlackPen = new Pen(color: Color.Black, width: 2);
            HomeWayGreenPen = new Pen(color: Color.Green, width: 2);
            PossibleCityBluePen = new Pen(color: Color.Blue, width: 1);
            ChoosenCityBlackPen = new Pen(color: Color.Black, width: 1);

            run = true;
            currentGeneration = 0;
            maxGeneration = GenerationTrackBar.Value;
            DoubleNumberFormat = "#.###";
            Delay = DelayTrackBar.Value;

            lookAtCurrentCityIndex = 0;
            lookAtPrevCityIndex = 0;
            
            GenerateBtn.PerformClick();
        }
        // OPTIONS
        private void UnlockInterface(bool locker)
        {
            ChildrenTrackBar.Enabled = locker;
            CityTrackBar.Enabled = locker;
            //DelayTrackBar.Enabled = locker;
            GenerationTrackBar.Enabled = locker;
            MutationTrackBar.Enabled = locker;
            PopulationTrackBar.Enabled = locker;

            GenerateBtn.Enabled = locker;
            StartBtn.Enabled = locker;
            EvaluateBtn.Enabled = locker;

            StartCityUpDown.Enabled = locker;

           // Map.Enabled = locker;

            run = !locker;
            CancelBtn.Enabled = !locker;
        }
        private void CityTrackBar_Scroll(object sender, EventArgs e)
        {
            CityAmount = CityTrackBar.Value;
            StartCityUpDown.Maximum = CityAmount;

            isGenerated = Cities.Length == CityAmount;
        }
        private void PopulationTrackBar_Scroll(object sender, EventArgs e)
        {
            VisiblePopulationSizeLbl.Text = PopulationTrackBar.Value.ToString();
            salesmen.PopulationSize = PopulationTrackBar.Value;
        }
        private void ChildrenTrackBar_Scroll(object sender, EventArgs e)
        {
            VisibleChildrenAmountLbl.Text = ChildrenTrackBar.Value.ToString();
            salesmen.ChildrenAmount = ChildrenTrackBar.Value;
        }
        private void MutationTrackBar_Scroll(object sender, EventArgs e)
        {
            VisibleMutationRateLbl.Text = MutationTrackBar.Value.ToString();
        }
        private void MutationTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            // on MouseUp cuz changing cost a lot of resources
            if(salesmen.MutationRate != MutationTrackBar.Value)
            {
                salesmen.MutationRate = MutationTrackBar.Value;
            }
        }
        private void GenerationTrackBar_Scroll(object sender, EventArgs e)
        {
            VisibleGenerationLbl.Text = GenerationTrackBar.Value.ToString();
            maxGeneration = GenerationTrackBar.Value;
        }
        private void DelayTrackBar_Scroll(object sender, EventArgs e)
        {
            VisibleDelayLbl.Text = DelayTrackBar.Value.ToString();
            Delay = DelayTrackBar.Value;
        }
        private void StartCityUpDown_ValueChanged(object sender, EventArgs e)
        {
            // rewrite indexes
            lookAtPrevCityIndex = lookAtCurrentCityIndex;
            lookAtCurrentCityIndex = StartCityIndex;
            // redraw cities into their color
            DrawCity(Cities[lookAtPrevCityIndex], CityRedPen);
            DrawCity(Cities[lookAtCurrentCityIndex], CityBluePen);
        }
        private void Map_Resize(object sender, EventArgs e)
        {
            graphic = Map.CreateGraphics();
        }
        private void Map_Paint(object sender, PaintEventArgs e)
        {
            DrawMap();
        }
        // DRAWING
        private void DrawTour(int[] Tour)
        {
            Point[] way = TourModel.GetWay(Tour, Cities);
            graphic.DrawLines(WayBlackPen, way);
            graphic.DrawLine(HomeWayGreenPen, way[0], way[way.Length - 1]);// sweet home
        }
        private void DrawTour(int[] Tour, double Cost)
        {
            DrawTour(Tour);
            CostToolStripStatusLabel.Text = "cost = " + Cost.ToString(DoubleNumberFormat);
        }
        private void DrawCity(CityModel.City city, Pen pen)
        {
            // -1 because offset
            graphic.DrawEllipse(pen, city.X - 1, city.Y - 1, 2, 2);
        }
        private void DrawMap()
        {
            graphic.Clear(Color.White);

            for (int i = 0; i < Cities.Length; ++i)
            {
                DrawCity(Cities[i], CityRedPen);
            }
        }
        // BTN / CLICK / DOUBLE CLICK / ...
        private void ChooseCityMap_MouseDown(object sender, MouseEventArgs e)
        {
            // rewrite indexes
            lookAtPrevCityIndex = lookAtCurrentCityIndex;
            lookAtCurrentCityIndex = StartCityIndex;

            // find the closest city to the click
            CityModel.City pointer = new CityModel.City(e.X, e.Y);
            double minDistance = double.MaxValue;

            for (int i = 0; i < Cities.Length; ++i)
            {
                double cutDistance = CityModel.distance(Cities[i], pointer);
                if (minDistance > cutDistance)
                {
                    minDistance = cutDistance;
                    lookAtCurrentCityIndex = i;
                }
            }
            // redraw cities into their color
            DrawCity(Cities[lookAtPrevCityIndex], CityRedPen);
            DrawCity(Cities[lookAtCurrentCityIndex], CityBluePen);
            // set city index in UpDown Control
            StartCityIndex = lookAtCurrentCityIndex;
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            SafeGenerate();
            DrawMap();
            UnlockInterface(false);
            CurrentGeneration = 0;
            RunGeneticAlgorithmAsync();
        }
        private void EvaluateBtn_Click(object sender, EventArgs e)
        {
            SafeGenerate();
            DrawMap();
            UnlockInterface(false);
            RunHillClimbingAlgorithmIterAsync();
            //RunHillClimbingAlgorithmAsync();
        }
        /* Refused, seems bad to me
         * delegate void SalesmanAlgo();
        private void Universal_Click(object sender, EventArgs e)
        {
            SalesmanAlgo[] algorithm = { RunGeneticAlgorithmAsync, RunHillClimbingAlgorithmIterAsync, RunHillClimbingAlgorithmAsync };
            SafeGenerate();
            DrawMap();
            UnlockInterface(false);
            CurrentGeneration = 0;
            // Supposed that buton tabIndex coincedence with algorithms
            algorithm[(sender as Button).TabIndex]();
        }*/
        private void SafeGenerate()
        {
            if (!isGenerated)
            {
                GenerateBtn.PerformClick();
            }
        }
        private void GenerateNewBtn_Click(object sender, EventArgs e)
        {
            Cities = CityModel.GetCitiesCoordinate(CityAmount: CityAmount, MapSize: Map.Size);
            DrawMap();

            // Population
            salesmen = new Population(PopulationSize: PopulationTrackBar.Value,
                                      ChildrenAmount: ChildrenTrackBar.Value,
                                      MutationRate: MutationTrackBar.Value,
                                      CitiesMap: Cities);

            isGenerated = true;
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            UnlockInterface(true);
        }

        // CODING PART
        private async void RunGeneticAlgorithmAsync()
        {
            await Task.Factory.StartNew(() =>
            {
                while (currentGeneration != maxGeneration && run)
                {
                    int IndividualIndex = 1;
                    foreach (Population.Individual salesman in salesmen.List)
                    {
                        DrawMap();
                        DrawTour(salesman.Tour, salesman.Cost);

                        IndividualToolStripStatusLabel.Text = $"individual = {IndividualIndex++}";

                        System.Threading.Thread.Sleep(delay);

                        if (OneInGenerationCheckBox.Checked || !run)
                        {
                            break;
                        }
                    }
                    GC.Collect();// burn all dead bodies
                    salesmen.GrowChildren();
                    ++CurrentGeneration;
                }
            }, TaskCreationOptions.LongRunning);
            UnlockInterface(true);
        }
        
        











        // TODO

        

        private async void RunHillClimbingAlgorithmIterAsync()
        {
            await Task.Factory.StartNew((object MutationRate) =>
            {
                mapState = graphic.Save();
                


                HillClimbing evr = new HillClimbing(Cities: Cities, StartedCity: StartCityIndex);
                
                foreach (HillClimbingArgs evrRes in evr.RunIter())
                {
                    if (evrRes.IsChosen)
                    {
                        graphic.DrawLine(ChoosenCityBlackPen, Cities[evrRes.CurrentCityIndex].Coordinate, Cities[evrRes.NextCityIndex].Coordinate);
                        Invoke((Action)delegate { DistanceToolStripStatusLabel.Text = "shortest distance = " + evrRes.Distance.ToString(DoubleNumberFormat); });

                        Thread.Sleep(delay);
                    }
                    else
                    {
                        graphic.DrawLine(PossibleCityBluePen, Cities[evrRes.CurrentCityIndex].Coordinate, Cities[evrRes.NextCityIndex].Coordinate);
                        Invoke((Action)delegate { DistanceToolStripStatusLabel.Text = "distance = " + evrRes.Distance.ToString(DoubleNumberFormat); });

                        Thread.Sleep(delay / 10);
                    }

                    if (!run)
                    {
                        return;
                    }
                }
                int[] tour = evr.result;

                double Cost = TourModel.Cost(tour, Cities);
                DrawMap();
                DrawTour(tour, Cost);
                salesmen.Insert(new Population.Individual(tour, Cost, (int)MutationRate));
                
            }, state: MutationTrackBar.Value, creationOptions: TaskCreationOptions.LongRunning);

            
            UnlockInterface(true);
            DistanceToolStripStatusLabel.Text = String.Empty;
        }

        delegate int[] SalesmanTour();
        private void RunHillClimbingAlgorithmAsync()
        {
            HillClimbing evr = new HillClimbing(Cities: Cities, StartedCity: StartCityIndex);

            evr.lookAtCity += WritePossibleCity;
            evr.ChooseACity += WriteCity;

            SalesmanTour HillClimbing = new SalesmanTour(evr.Run);
            int MutationRate = MutationTrackBar.Value;


            HillClimbing.BeginInvoke(AsyncResult =>
            {
                int[] tour = HillClimbing.EndInvoke(AsyncResult);
                double Cost = TourModel.Cost(tour, Cities);
                DrawMap();
                DrawTour(tour, Cost);
                salesmen.Insert(new Population.Individual(tour, Cost, MutationRate));
                Invoke((Action)delegate 
                {
                    UnlockInterface(true);
                    DistanceToolStripStatusLabel.Text = String.Empty;
                });
            }, null);
        }

        int prevCityIndex = 0;
        private void WritePossibleCity(object sender, HillClimbingArgs e)
        {
            /*
            graphic.DrawLine(new Pen(Color.White), Cities[e.CityIndex].Coordinate, Cities[prevCityIndex].Coordinate);
            prevCityIndex = e.NextCityIndex;*/

            //graphic.Restore(mapState);
            if (!run)
            {
                Thread.CurrentThread.Abort();
            }
            graphic.DrawLine(PossibleCityBluePen, Cities[e.CurrentCityIndex].Coordinate, Cities[e.NextCityIndex].Coordinate);
            Invoke((Action) delegate { DistanceToolStripStatusLabel.Text = "distance = " + e.Distance.ToString(DoubleNumberFormat); } );
            Thread.Sleep(delay / 10);
        }

        private void WriteCity(object sender, HillClimbingArgs e)
        {
            //graphic.Restore(mapState);
            if (!run)
            {
                Thread.CurrentThread.Abort();
            }
            graphic.DrawLine(ChoosenCityBlackPen, Cities[e.CurrentCityIndex].Coordinate, Cities[e.NextCityIndex].Coordinate);
            Invoke((Action)delegate { DistanceToolStripStatusLabel.Text = "shortest distance = " + e.Distance.ToString(DoubleNumberFormat); });
            Thread.Sleep(delay);

            // mapState = graphic.Save();
        }




        private void SetNewCityMap_MouseDown(object sender, MouseEventArgs e)
        {
            // isGenerated = false;
            CityModel.City[] oldArr = Cities;
            Cities = new CityModel.City[Cities.Length + 1];
            oldArr.CopyTo(Cities, 0);
            Cities[oldArr.Length] = new CityModel.City(e.X - 1, e.Y - 1);
            DrawCity(Cities[oldArr.Length], CityRedPen);
            CityAmount++;
            salesmen = new Population(PopulationSize: PopulationTrackBar.Value,
                                      ChildrenAmount: ChildrenTrackBar.Value,
                                      MutationRate: MutationTrackBar.Value,
                                      CitiesMap: Cities);
            StartCityUpDown.Maximum = CityAmount;

        }




        
        
        
    }
}
