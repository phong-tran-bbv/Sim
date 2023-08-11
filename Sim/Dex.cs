namespace Sim;

public class Dex
{
    public static ModdedDex I;
}

public class ModdedDex
{
    public int gen;
    public DexFormats Formats { get; set; }

    public ModdedDex ForFormat(Format format)
    {
        return null;
    }
}