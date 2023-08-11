using System;

namespace Sim;

public class Battle
{
    private string[] log;
    private Format format;
    private ModdedDex dex;
    private int gen;
    private RuleTable ruleTable;

    public Battle(BattleOptions options)
    {
        this.log = new string[0];
        //TODO: this.add('t:', Math.floor(Date.now() / 1000));
        this.format = options.Format ?? Dex.I.Formats.Get(options.Formatid, true);
        this.dex = Dex.I.ForFormat(this.format);
        this.gen = this.dex.gen;
        this.ruleTable = this.dex.Formats.GetRuleTable(this.format);

        //TODO: this.trunc = this.dex.trunc;
    }
}

public class BattleOptions
{
    public Format Format { get; set; }
    public string Formatid { get; set; }
    public bool Debug { get; set; }

    public Action<string, string[]> Send;
}