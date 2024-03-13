using System.Xml.Linq;
using System.Xml;

namespace Song_Entry_Form
{
    public partial class SongEntryForm : Form
    {
        public SongEntryForm()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (
                title.Text == "" ||
                genre.Text == "" ||
                dura.Text == "" ||
                label.Text == "" ||
                artist.Text == ""
                )
            {
                output.Text = "All text bxes must be filled";
                output.Visible = true;
                return;
            }

            output.Visible = false;

            if (!File.Exists("songs.xml"))
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create("songs.xml", xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("songs");

                    xmlWriter.WriteStartElement("song");

                    xmlWriter.WriteElementString("title", title.Text);
                    xmlWriter.WriteElementString("genre", genre.Text);
                    xmlWriter.WriteElementString("duration", dura.Text);
                    xmlWriter.WriteElementString("label", label.Text);
                    xmlWriter.WriteElementString("artist", artist.Text);

                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndDocument();

                    xmlWriter.Flush();

                    xmlWriter.Close();

                }

            }
            else
            {
                XDocument xDocument = XDocument.Load("songs.xml");

                XElement root = xDocument.Element("songs");

                IEnumerable<XElement> rows = root.Descendants("song");

                XElement firstRow = rows.First();

                firstRow.AddBeforeSelf(

                   new XElement("song",

                   new XElement("title", title.Text),

                   new XElement("genre", genre.Text),

                   new XElement("duration", dura.Text),

                   new XElement("label", label.Text),

                   new XElement("artist", artist.Text)));

                xDocument.Save("songs.xml");
            }
        }
    }
}
