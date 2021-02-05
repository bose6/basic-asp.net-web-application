using System;

namespace webdevelopement.App_Start
{
    // public class manager
    //{
    //}
}
public class Setting
{
    public string text1 { get; set; }
    public string text2 { get; set; }
    public string dFooter { get; set; }
    public string Header { get; set; }
    public int visitor =0;


}
public class manager
{

    public manager()
    {


    }

    public static Setting Loadsetting(string filepath)
    {

        Setting S = new Setting();
        try
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Setting));
            System.IO.StreamReader file = new System.IO.StreamReader(filepath);
            S = (Setting)reader.Deserialize(file);
            file.Close();
            return S;

        }
        catch (Exception)
        {
            return S;

        }

    }

    public static void Savesettings(string filepath, Setting Settingobj)
    {
        System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Setting));
        
        System.IO.FileStream file = System.IO.File.Create(filepath);

        writer.Serialize(file, Settingobj);
        file.Close();
    }
}