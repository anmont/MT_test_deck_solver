using System.Xml.Linq;

namespace MT_test_deck_solver
{
    public class votePermutations
    {
        public string VoteName { get; set; }
        public List<int> Selection { get; set; }

    }
    public class vote
    {
        public string VoteName { get; set; }
        public List<string> Choices { get; set; }
        public bool Overvote { get; set; }
        public bool Undervote { get; set; }
        public int VoterChoices { get; set; }
    }
    public class ballot
    {
        public string Precinct { get; set; }
        public List<vote> Votes { get; set; }
    }
    public partial class Form1 : Form
    {
        string sourceFilePath = "C:\\Users\\anmon\\OneDrive\\Desktop\\ballot.xml";
        List<ballot> allBallots = new List<ballot>();
        List<votePermutations> permutations = new List<votePermutations>();

        public Form1()
        {
            InitializeComponent();
            txtSourceFile.Text = sourceFilePath;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string addPrecinct;
            List<vote> addVotes;

            //load the xml file into the xml element
            XElement xml = XElement.Load(@sourceFilePath);

            IEnumerable<XElement> allPrecints = xml.Elements("precinct");


            foreach (var precinct in allPrecints)
            {
                List<vote> tmpVotes = new List<vote>();
                ballot ballotItem = new ballot();
                ballotItem.Precinct = precinct.Attribute("name").Value.ToString();

                foreach (var locVotes in precinct.Elements("vote"))
                {
                    vote temp = new vote();
                    
                    temp.VoteName = locVotes.Attribute("name").Value.ToString();
                    List<string> tmpOptions = new List<string>();

                    foreach (var choice in locVotes.Elements("choices").Elements("choice"))
                    {
                        tmpOptions.Add(choice.Attribute("name").Value.ToString());

                    }

                    foreach (var option in locVotes.Elements("options").Elements())
                    {
                        if (option.Name == "overVote")
                        {
                            if (option.Value == "True")
                            {
                                temp.Overvote = true;
                            }
                            else
                            {
                                temp.Overvote = false;
                            }
                        }
                        else if (option.Name == "underVote")
                        {
                            if (option.Value == "True")
                            {
                                temp.Undervote = true;
                            }
                            else
                            {
                                temp.Undervote = false;
                            }
                        }
                        else if (option.Name == "writeIn")
                        {
                            temp.VoterChoices = int.Parse(option.Value);
                        }
                    }
                    
                    temp.Choices = tmpOptions;
                    tmpVotes.Add(temp);
                    ballotItem.Votes = tmpVotes;
                    allBallots.Add(ballotItem);
                }

            }           
        }

        private void btnChooseSource_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    sourceFilePath = openFileDialog.FileName;
                }
            }
            if (sourceFilePath != string.Empty)
            {
                txtSourceFile.Text = sourceFilePath;
            }
        }
    }
}
