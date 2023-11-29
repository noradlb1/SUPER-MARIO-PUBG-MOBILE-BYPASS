using System;
using System.IO;
using System.Xml.Serialization;

namespace numer
{
	// Token: 0x0200003C RID: 60
	public class SaveXML
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x000106D4 File Offset: 0x0000E8D4
		public static void SaveData(object obj, string filename)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
			TextWriter textWriter = new StreamWriter(filename);
			xmlSerializer.Serialize(textWriter, obj);
			textWriter.Close();
		}
	}
}
