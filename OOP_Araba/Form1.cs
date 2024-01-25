namespace OOP_Araba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Araba> arabaList = new List<Araba>();
        private void button1_Click(object sender, EventArgs e)
        {
            Araba yeniAraba= new Araba();
            yeniAraba.MotorHacmi =(int) numericUpDown1.Value;
            yeniAraba.Marka=txtMarka.Text;
            
            
            if (radioButton1.Checked)
            {
                yeniAraba.Renk = radioButton1.Text;
            }else if(radioButton2.Checked)
            {
                yeniAraba.Renk= radioButton2.Text;
            }
            yeniAraba.Yil = int.Parse(txtYil.Text);
            yeniAraba.Model = int.Parse(txtModel.Text);

          
            arabaList.Add(yeniAraba);
      

        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            foreach (Araba item in arabaList)
            {
                listBox1.Items.Add("-----------------------------");
                listBox1.Items.Add(item.Marka);
                listBox1.Items.Add(item.Model);
                listBox1.Items.Add(item.Yil);
                listBox1.Items.Add(item.Renk);
                listBox1.Items.Add(item.MotorHacmi);
            }
            
        }
    }
    public class Araba
    {
        public string Marka { get; set; }
        public int Model{ get; set; }
        public int Yil { get; set; }
        public string Renk { get; set; }
        public int MotorHacmi { get; set; }
    }
}