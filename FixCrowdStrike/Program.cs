Console.WriteLine("""
                             _            _     _ _
                   _ __ __ _(_)_ __ __  _| |__ / / |
                  | '__/ _` | | '_ \\ \/ / '_ \| | |
                  | | | (_| | | | | |>  <| | | | | |
                  |_|  \__,_|_|_| |_/_/\_\_| |_|_|_|
                                                    
                  made by: https://github.com/rainxh11

                  Remember Kids, it's never too late to ditch windows,
                  & 3rd party kernel level drivers is a ticking time bomb waiting to go off

                  """);

var drives = DriveInfo.GetDrives()
                      .Where(drive => drive.DriveType is not DriveType.CDRom and not DriveType.Network);
foreach (var folder in drives)
{
  try
  {
    var driverFolder = new DirectoryInfo(Path.Combine(folder.RootDirectory.FullName, "windows", "system32", "drivers", "CrowdStrike "));
    if (driverFolder.Exists)
    {
      Console.WriteLine("Found CrowdStrike folder: {0}", driverFolder.FullName);

      var problematicDrivers = driverFolder.EnumerateFiles("*.sys", SearchOption.AllDirectories)
                                           .Where(file => file.Name.StartsWith("C-00000291", StringComparison.OrdinalIgnoreCase));
      foreach (var driverFile in problematicDrivers)
      {
        try
        {
          driverFile.Delete();
          Console.WriteLine("Deleted file: {0}", driverFile.FullName);
        }
        catch (IOException ex)
        {
          Console.WriteLine("Couldn't delete file: {0}, Exception: {1}", driverFile.FullName, ex.Message);
        }
      }
    }
  }
  catch
  {
  }
}

Console.WriteLine("Press Any Key to Exit and Shutdown...");
Console.ReadKey();