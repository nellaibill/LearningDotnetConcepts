namespace OOPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toastMessage.Visible = false;
        }

        private void Shadowing_Click(object sender, EventArgs e)
        {
            Shadowing sh = new Shadowing();
            sh.InvoiceNumber = 100;


            Shadwing2 sh2 = new Shadwing2();
            sh2.InvoiceNumber = "A-100";

            ShowToastMessage("• Shadowing : Replaces the current element of the parent  \r\n\t• It is useful when vocabulary will be same but datatype needs to be changed\r\nOverriding  : Replace the implementation");
        }

        private void Scenario1_Click(object sender, EventArgs e)
        {
            I1 i1 = new Scenario1();
            i1.Method1();
            I2 i2 = new Scenario1();
            i2.Method1();
            ShowToastMessage("Your message here");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void ShowToastMessage(string message)
        {
            toastMessage.Text = message;
            toastMessage.Visible = true;
            await Task.Delay(10000); // Delay for 10 seconds
            toastMessage.Visible = false;
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            StaticClass.IncrementCounter += 1;
            ShowToastMessage(StaticClass.IncrementCounter.ToString());

        }

        private void btnAssociation_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();

            SwipeCard sCard = new SwipeCard();

            manager.Login(sCard); // Manager Associates with Swipe card

            manager.GetManagerName();
            sCard.Swipe(manager);

            ShowToastMessage("• Manager has a swipe card to enter company premises\r\nBoth Classes - Know each other none of them are owners");
        }

        private void btnOperatorOverloading_Click(object sender, EventArgs e)
        {
            OperatorOverloading obj1 = new OperatorOverloading();
            obj1.Num1 = 10;
            obj1.Str1 = "Mohamed ";

            OperatorOverloading obj2 = new OperatorOverloading();
            obj2.Num1 = 20;
            obj2.Str1 = "Saleem";

            OperatorOverloading obj3 = new OperatorOverloading();
            obj3 = obj1 + obj2;



        }
    }
}
