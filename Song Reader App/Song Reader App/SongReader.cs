using System.Xml;

namespace Song_Reader_App
{
    public partial class SongReader : Form
    {
        public SongReader()
        {
            InitializeComponent();
        }

        private void readFile_Click(object sender, EventArgs e)
        {
            string title = "", genre = "", dura = "", label = "";

            if (!File.Exists("songs.xml"))
            {
                return;
            }

            lstOut.Items.Clear();

            using (XmlReader reader = XmlReader.Create("songs.xml"))
            {
                while (reader.Read())
                {
                    // ListViewItem listItem = new ListViewItem();   //"Row" object.
                    if (reader.IsStartElement())
                    {
                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        {
                            case "title":
                                //Store the data element title 
                                title = reader.ReadString();
                                break;
                            case "genre":
                                genre = reader.ReadString();
                                break;
                            case "duration":
                                dura = reader.ReadString();
                                break;
                            case "label":
                                label = reader.ReadString();
                                break;
                            case "artist":
                                //When all fields have been read - next element will be artist 

                                string artist = reader.ReadString();

                                // if field all have values
                                if (title == "" || genre == "" || dura == "" || label == "" || artist == "")
                                {
                                    break;
                                }

                                //Add the row object to the listview.
                                ListViewItem listItem = new ListViewItem();
                                listItem.Text = title;
                                listItem.SubItems.Add(genre);
                                listItem.SubItems.Add(dura);
                                listItem.SubItems.Add(label);
                                listItem.SubItems.Add(artist);

                                //display entire listview row
                                lstOut.Items.Add(listItem);

                                break;
                        }
                    }
                }
            }
        }
    }
}
