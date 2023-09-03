using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Layout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string description = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void myGrid_Click(object sender, RoutedEventArgs e)
        {
            description = "Grid - самый распространненный контейнер, представляющий из себя таблицу," +
                "с возможностью обьединения ячеек." +
                "Для удобства работы , лучше использовать двумерный массив.";
            MessageBox.Show(description);
            mGrid mGrid = new mGrid();
            mGrid.Show();
        }

        private void myStacPanel_Click(object sender, RoutedEventArgs e)
        {
            description = "Stack Panel - контейнер в котором все элементы располагаються," +
                "либо вертикально ,либо горизантально , в зависимомти от выбранного параметра.";
            MessageBox.Show(description);
            mStack stack = new mStack();
            stack.Show();
        }

        private void myDockPanel_Click(object sender, RoutedEventArgs e)
        {
            description = "Dock Panel -   в этом контейнере , элемнты прижимаються к стороне указанной " +
                "через свойство DockPanel.Dock";
            MessageBox.Show(description);
            mDock mDock = new mDock();
            mDock.Show();
        }

        private void myWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            description = "Wrap Panel - Элементы распологаються в ряд как и в контейнре StackPanel," +
                "с отличием в том, что компоненты не поместившиеся в ряд образуют новый ряд.";
            MessageBox.Show(description);
            mWrap mWrap = new mWrap();
            mWrap.Show();
        }

        private void myCanvas_Click(object sender, RoutedEventArgs e)
        {
            description = "Canvas - Для размещения на, нем необходимо указать для элементов, точные координаты относительно сторон";
            MessageBox.Show(description);
            mCanvas mCanvas = new mCanvas();
            mCanvas.Show();
        }
    }
}
