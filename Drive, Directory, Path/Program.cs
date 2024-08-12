internal class Program
{
    private static void Main(string[] args)
    {
        //DriveInfo


        var friveInfos = DriveInfo.GetDrives();

        /*    foreach (var f in friveInfos)
            {
                Console.WriteLine(f.Name + "  " + f.RootDirectory + f.TotalSize);
            }

            foreach (var d in friveInfos.Select(x => x.RootDirectory))
            {
                var files = d.GetFiles();


                foreach (var f in files)
                {
                    Console.WriteLine(f.Name);
                }

                var directories = d.GetDirectories();

                foreach (var directory in directories)
                {
                    Console.WriteLine(directory.Name);
                }
            }*/


        Console.WriteLine(Path.GetFileName("C:\\Users\\sardo\\OneDrive\\Рабочий стол\\Projects\\C#Tutorial\\Drive, Directory, Path\\Program.cs"));
    }
}