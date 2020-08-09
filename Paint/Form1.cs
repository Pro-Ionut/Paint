using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Graf
{
    public partial class Main : Form
    {
        
        private Pen myPen = new Pen(Color.Black, 5);
        private GraphicTool GraphicTool = new GraphicTool();
        private bool IsMouseDown { get; set; } = false;
        Graphics graphics;
        Point point;

        private string Form { get => comboBoxShapes.SelectedItem.ToString(); }
        public Main()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            

        }

        private void Main_Click(object sender, EventArgs e)
        {
            point = this.PointToClient(Cursor.Position);
            if (comboBoxShapes.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(txtRadius.Text))
                    MessageBox.Show("You can't create a circle becouse radius is required.");
                else
                {

                    Circle circle = new Circle(Int32.Parse(txtRadius.Text), point);
                    circle.Draw(graphics, myPen);

                }
            }
            else if (comboBoxShapes.SelectedIndex==1)
            {
                if (String.IsNullOrEmpty(txtWidth.Text))
                    MessageBox.Show("You can't create a square becouse width is required.");

                else
                {
                    ;
                    Square square = new Square(Int32.Parse(txtWidth.Text), point);
                    square.Draw(graphics, myPen);

                }
            }    

        }

        private void ColorPicker_Click(object sender, EventArgs e)
        {
            if(ColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                myPen.Color = ColorDialog.Color;
            }
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {

            if (comboBoxShapes.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(txtSize.Text))
                    MessageBox.Show("You can't resize this circle becouse size is required.");
                else
                {

                    graphics.Clear(Color.LightGray);
                    Circle circle = new Circle(Int32.Parse(txtRadius.Text), point);
                    circle.Resize(Int32.Parse(txtSize.Text), graphics);
                    circle.Draw(graphics, myPen);

                }
            }
            else if (comboBoxShapes.SelectedIndex == 1)
            {


                if (String.IsNullOrEmpty(txtSize.Text))
                    MessageBox.Show("You can't resize this square becouse size is required.");


                else
                {
                    graphics.Clear(Color.LightGray);

                    Square square = new Square(Int32.Parse(txtWidth.Text), point);
                    square.Resize(Int32.Parse(txtSize.Text), graphics);
                    square.Draw(graphics, myPen);



                }
            }

        }

        private void shapeSizeButton_Click(object sender, EventArgs e)
        {
            // TransferData.Value;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // new form;            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
            


        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //MouseEventArgs mouse = (MouseEventArgs)e;
            //Point location = mouse.Location;
            //System.Drawing.Graphics graphicsObj;

            //graphicsObj = panelDraw.CreateGraphics();


            //Rectangle myRectangle = new Rectangle(location.X, location.Y, 40, 40);
            //graphicsObj.DrawEllipse(myPen, myRectangle);
        }

        private void buttonClearPaint_Click(object sender, EventArgs e)
        {

           
        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
       
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxShapes.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(txtX.Text))
                    MessageBox.Show("You can't move this circle becouse X coordonate is required.");
                else if (String.IsNullOrEmpty(txtY.Text))
                {
                    MessageBox.Show("You can't move this circle becouse Y coordonate is required.");
                }
                else
                {
                    graphics.Clear(Color.LightGray);
                    Point p = new Point(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtY.Text));
                    Circle circle = new Circle(Int32.Parse(txtRadius.Text), p);
                    circle.pen= myPen;
                    circle.MoveTo(p, graphics);



                }
            }
            else if (comboBoxShapes.SelectedIndex == 1)
            {


                if (String.IsNullOrEmpty(txtX.Text))
                    MessageBox.Show("You can't move this square becouse X coordonate is required.");
                else if (String.IsNullOrEmpty(txtY.Text))
                {
                    MessageBox.Show("You can't move this square becouse Y coordonate is required.");
                }
                else
                {
                    graphics.Clear(Color.LightGray);
                    Point p = new Point(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtY.Text));
                    Square square = new Square(Int32.Parse(txtWidth.Text), p);
                    square.pen = myPen;
                    square.MoveTo(p, graphics);



                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.LightGray);
        }
    }
    }

