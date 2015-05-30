using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;


namespace rn.rn_inform.test
{
    static class Xml
    {
        public static T ImportXml<T>(String FileName) where  T: class
        {
            T ResultObject = null;

            try
            {
                var XmlReader = new XmlTextReader(FileName);
                XmlReader.Namespaces = false;

                var XmlSerializer = new XmlSerializer(typeof(T));
                ResultObject = (T)XmlSerializer.Deserialize(XmlReader);
            }
            catch (XmlException e) 
            {
                MessageBox.Show(e.Message, "Ошибка XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ResultObject;
        }

        public static void ExportXml<T>(String FileName, T inputObject) where T: class
        {
            var XmlWriter = new XmlTextWriter(FileName, null);
            XmlWriter.Namespaces = false;
            try
            {
                var XmlSerializer = new XmlSerializer(typeof(T));
                XmlSerializer.Serialize(XmlWriter, inputObject);
            }
            catch (XmlException e)
            {
                MessageBox.Show(e.Message, "Ошибка XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                XmlWriter.Close();
            }
        }
    }
}
