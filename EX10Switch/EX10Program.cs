namespace EX10Switch
{
    internal class EX10Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a) Kæledyrsopslagsværk\nb) Karakterbeskrivelsen");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.Clear();
            switch (keyInfo.Key)
            {
                case ConsoleKey.A:
                        Console.WriteLine("Indtast en af følgene dyr:\n" +
                            "Gris, Hund, Kat Undulat eller Papegøje:");
                        string input = Console.ReadLine();
                        switch (input.ToLower())
                        {
                            case "gris":
                                Console.WriteLine("Grisen har en grisehale og leverer bacon.");
                                break;
                            case "hund":
                                Console.WriteLine("Hunde kan lygte mindst 40 gange bedre end os");
                                break;
                            case "kat":
                                Console.WriteLine("Katte kan hoppe 5 gange deres højde");
                                break;
                            case "undulat":
                                Console.WriteLine("En undulat kan mimic meneske snak");
                                break;
                            case "papegøje":
                                Console.WriteLine("Papegøjer kan leve i årtier");
                                break;
                            default:
                                Console.WriteLine("Error...");
                                break;
                        }
                        break;

                case ConsoleKey.B:
                    Console.WriteLine("Indtast en af følgene karaktere:\n" +
                            "-3, 00, 02, 4, 7, 10 eller 12::");
                    string grade = Console.ReadLine();
                    switch (grade.ToLower())
                    {
                        case "-3":
                            Console.WriteLine("For den ringe præstation. Karakteren -3 gives for den helt uacceptable præstation.");
                            break;
                        case "00":
                            Console.WriteLine("For den utilstrækkelige præstation. Karakteren 00 gives for den utilstrækkelige præstation, der ikke demonstrerer en acceptabel grad af opfyldelse af fagets/fagelementets mål.");
                            break;
                        case "02":
                            Console.WriteLine("For den tilstrækkelige præstation. Karakteren 02 gives for den tilstrækkelige præstation, der demonstrerer den minimalt acceptable grad af opfyldelse af fagets/fagelementets mål.");
                            break;
                        case "4":
                            Console.WriteLine("For den jævne præstation. Karakteren 4 gives for den jævne præstation, der demonstrerer en mindre grad af opfyldelse af fagets/fagelementets mål, med adskillige væsentlige mangler.");
                            break;
                        case "7":
                            Console.WriteLine("For den gode præstation. Karakteren 7 gives for den gode præstation, der demonstrerer opfyldelse af fagets/fagelementets mål, med en del mangler.");
                            break;
                        case "10":
                            Console.WriteLine("For den fortrinlige præstation. Karakteren 10 gives for den fortrinlige præstation, der demonstrerer omfattende opfyldelse af fagets/fagelementets mål, med nogle mindre væsentlige mangler.");
                            break;
                        case "12":
                            Console.WriteLine("For den fremragende præstation. Karakteren 12 gives for den fremragende præstation, der demonstrerer udtømmende opfyldelse af fagets/fagelementets mål, med ingen eller få uvæsentlige mangler.");
                            break;
                        default:
                            Console.WriteLine("Error...");
                            break;
                    }
                    break;
               
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ukendt tastetryk");
                    break;
            }

        }
    }
}
