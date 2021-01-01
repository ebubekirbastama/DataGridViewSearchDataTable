using System.Windows.Forms;
using System.Data;

namespace ebstimecms
{
    public class kategoriler
    {
    //"Category LIKE" Buraya Datatable'daki kolon adını yazıyoruz...
        public static void search(string kelime,DataGridView dtgrd)
        {
            DataView dw = new DataView(ConvertToDatatble());
            dw.RowFilter = string.Format("Category LIKE '%{0}%'", kelime);
            dtgrd.DataSource = dw;

        }
    }
}
