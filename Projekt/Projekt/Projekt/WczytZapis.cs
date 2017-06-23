using System;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Projekt
{
    public static class WczytZapis
    {
        public static void zapisz(Baza baz, String filePath)
        {
            Stream stream = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, baz);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                if (null != stream)
                    stream.Close();
            }
        }
        public static Baza wczytaj(String filePath)
        {
            Stream stream = null;
            Baza baz = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(filePath, FileMode.Open);
                baz = (Baza)formatter.Deserialize(stream);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                if (null != stream)
                    stream.Close();
            }
            return baz;
        }
    }
}
