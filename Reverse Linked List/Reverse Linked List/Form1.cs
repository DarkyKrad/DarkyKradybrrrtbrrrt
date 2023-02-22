namespace Reverse_Linked_List
{
    public partial class Form1 : Form
    {
        LinkedList list = new LinkedList();


        public Form1()
        {
            InitializeComponent();
        }

        private void ReverseBtn_Click(object sender, EventArgs e)
        {
            list.AddNode(new LinkedList.Node(HeadTxtbx.Text));
            list.AddNode(new LinkedList.Node(Node1Txtbx.Text));
            list.AddNode(new LinkedList.Node(Node2Txtbx.Text));
            list.AddNode(new LinkedList.Node(Node3Txtbx.Text));
            list.AddNode(new LinkedList.Node(Node4Txtbx.Text));
            list.AddNode(new LinkedList.Node(Node5Txtbx.Text));

            list.ReverseList();

            lblOutput.Text = list.ToString();
            list.Clearlist();
        }
    }
}