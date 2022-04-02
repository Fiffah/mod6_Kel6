using System;

public class GlossaryItem
{
	public GlossaryItem()
	{
		var json = {
	"glossary": {
			"title": "example glossary",
		"GlossDiv": {
				"title": "S",
			"GlossList": {
					"GlossEntry": {
						"ID": "SGML",
					"SortAs": "SGML",
					"GlossTerm": "Standard Generalized Markup Language",
					"Acronym": "SGML",
					"Abbrev": "ISO 8879:1986",
					"GlossDef": {
							"para": "A meta-markup language, used to create markup languages such as DocBook.",
						"GlossSeeAlso": [ "GML", "XML" ]
					},
					"GlossSee": "markup"
					}
				}
			}
		}

		var GloassaryItem = JsonSerializer.Deserialize<GloassaryItem>(json);

		Console.Writeline($"GloassaryItem.glossary: {GloassaryItem.glossary});

		Console.Writeline($"GloassaryItem.title: {GloassaryItem.title});

		Console.Writeline($"GloassaryItem.GlossDiv: {GloassaryItem.GlossDiv});

		Console.Writeline($"GloassaryItem.title: {GloassaryItem.title});

		Console.Writeline($"GloassaryItem.GlossList: {GloassaryItem.GlossList});

		Console.Writeline($"GloassaryItem.GlossEntry: {GloassaryItem.GlossEntry});

		Console.Writeline($"GloassaryItem.ID: {GloassaryItem.ID});

		Console.Writeline($"GloassaryItem.SortAs: {GloassaryItem.SortAs});

		Console.Writeline($"GloassaryItem.GlossTerm: {GloassaryItem.GlossTerm});

		Console.Writeline($"GloassaryItem.Acronym: {GloassaryItem.Acronym});

		Console.Writeline($"GloassaryItem.Abbrev: {GloassaryItem.Abbrev});

		Console.Writeline($"GloassaryItem.GlossDef: {GloassaryItem.GlossDef});

		Console.Writeline($"GloassaryItem.para: {GloassaryItem.para});

		Console.Writeline($"GloassaryItem.GlossSeeAlso: {GloassaryItem.GlossSeeAlso});

		Console.Writeline($"GloassaryItem.GlossSee: {GloassaryItem.GlossSee});


	}
}