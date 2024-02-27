using Vadapav;

try
{
    Console.WriteLine("Hello, World!");

    var client = new VadapavClient("https://vadapav.mov");
    var outputPath = "./Downloads";
    var directoryId = "821f5ea6-b351-4ad9-8cd3-45f245e404ef";

    var directory = await client.GetDirectoryAsync(directoryId);
    Console.WriteLine($"Selected directory name: {directory.Name}");

    await client.DownloadDirectoryAsync("821f5ea6-b351-4ad9-8cd3-45f245e404ef", outputPath); 
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
