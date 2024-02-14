using System.Data;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LogicLayer;

namespace GameOfLifeHMI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window //, GameObserver
    {
    //    private TimeEvolve? timer;
    //    private GameOfLife? game;
     //   private Rule rule;
        private WriteableBitmap? bitmap;
        private const int deadColor = 0xFFFFFF;
        private const int liveColor = 0xFF0000;
        public MainWindow()
        {
            InitializeComponent();
            // rule = new ClassicRule();
        }
        private void InitRandom(object sender, RoutedEventArgs e)
        {
            try
            {
                int nbRows = Convert.ToInt32(rows.Text);
                int nbCols = Convert.ToInt32(columns.Text);
          //      game = new GameOfLife(nbRows, nbCols, rule, this);
          //      timer = new TimeEvolve(game);
                CreateBoard(nbRows, nbCols);
                DrawBoard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateBoard(int rows, int cols)
        {
            bitmap = new WriteableBitmap(rows, cols, 96, 96, PixelFormats.Bgr32, null);
            RenderOptions.SetBitmapScalingMode(board, BitmapScalingMode.NearestNeighbor);
            board.Source = bitmap;
        }

        private void DrawBoard()
        {
            /*
            Debug.Assert(game != null);
            Debug.Assert(bitmap != null);
            bool[,] states = game.States;
            int rows = states.GetLength(0);
            int cols = states.GetLength(1);

            try
            {
                bitmap.Lock();
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        int color = states[row, col] ? liveColor : deadColor;
                        unsafe
                        {
                            var ptr = bitmap.BackBuffer;
                            ptr += row * bitmap.BackBufferStride;
                            ptr += col * 4;
                            *((int*)ptr) = color;
                        }
                    }
                }
                bitmap.AddDirtyRect(new Int32Rect(0, 0, rows, cols));
            }
            finally
            {
                bitmap.Unlock();
            }
            */
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            /*
            try
            {
                int ms = Convert.ToInt32(timeMS.Text);
                TimeSpan time = TimeSpan.FromMilliseconds(ms);
                timer?.Start(time);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void Stop(object sender, RoutedEventArgs e)
        {
           // timer?.Stop();
        }

        public void ChangeState()
        {
            Dispatcher.BeginInvoke(() =>
            {
                DrawBoard();
            });

        }
    }

}