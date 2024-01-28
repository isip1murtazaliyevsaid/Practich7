using Проводник;
using System.Diagnostics;




static void ShowPapkaD(String s)
{
    while (true)
    {
        Console.Clear();
        string[] paths = Directory.GetDirectories(s);
        string[] sd = Directory.GetFiles(s);

        foreach (string path in paths)
        {
            Console.WriteLine("  " + path + "                             " + System.IO.File.GetCreationTime(path).ToString());
        }
        foreach (string path in sd)
        {
            Console.WriteLine("  " + path + "                             " + System.IO.File.GetCreationTime(path).ToString());
        }
        SR_menu sr = new SR_menu();
        int pos = sr.sr();
        if (pos == -1)
        {
            ShowPapkaC("D:\\");
        }
        if (pos == -90)
        {
            return;
        }

        ShowPapkaD(paths[pos]);
    }
}


static void ShowPapkaC(String s)
{
    while (true)
    {
        Console.Clear();
        string[] paths = Directory.GetDirectories(s);
        string[] sd = Directory.GetFiles(s);

        foreach (string path in paths)
        {
            Console.WriteLine("  " + path + "                             " + System.IO.File.GetCreationTime(path).ToString());
        }
        foreach (string path in sd)
        {
            Console.WriteLine("  " + path + "                             " + System.IO.File.GetCreationTime(path).ToString());
        }
        SR_menu sr = new SR_menu();
        int pos = sr.sr();
        if (pos == -1)
        {
            ShowPapkaC("C:\\");
        }
        if (pos == -90)
        {
            return;
        }

        ShowPapkaC(paths[pos]);
    }
}




Console.WriteLine("  Выберите диск");
DriveInfo[] drives = DriveInfo.GetDrives();


foreach (DriveInfo drive in drives)
{
    Console.WriteLine("  " + drive.Name + " Свободно " + drive.TotalFreeSpace / 1024 / 1024 / 1024 + " ГБ " + "из " + drive.TotalSize / 1024 / 1024 / 1024 + " ГБ");
}

SR_menu sr = new SR_menu();
int pos = sr.sr();
if (pos == -90)
{
    return;
}

if (pos == 1)
{
    ShowPapkaC("C:\\");
}

if (pos == 2)
{
    ShowPapkaD("D:\\");
}




