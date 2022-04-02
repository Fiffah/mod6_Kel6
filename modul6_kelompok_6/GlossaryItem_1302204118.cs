using System;

public class GlossaryItem
{
	public GlossaryItem()
	{
		var json = {

				}
			}
		}

		var GloassaryItem = JsonSerializer.Deserialize<GloassaryItem>(json);

		Console.WriteLine($"GloassaryItem.glossary: {GloassaryItem.glossary});

		Console.WriteLine($"GloassaryItem.title: {GloassaryItem.title});

		Console.WriteLine($"GloassaryItem.GlossDiv: {GloassaryItem.GlossDiv});

		Console.WriteLine($"GloassaryItem.title: {GloassaryItem.title});

		Console.WriteLine($"GloassaryItem.GlossList: {GloassaryItem.GlossList});

		Console.WriteLine($"GloassaryItem.GlossEntry: {GloassaryItem.GlossEntry});

		Console.WriteLine($"GloassaryItem.ID: {GloassaryItem.ID});

		Console.WriteLine($"GloassaryItem.SortAs: {GloassaryItem.SortAs});

		Console.WriteLine($"GloassaryItem.GlossTerm: {GloassaryItem.GlossTerm});

		Console.WriteLine($"GloassaryItem.Acronym: {GloassaryItem.Acronym});

		Console.WriteLine($"GloassaryItem.Abbrev: {GloassaryItem.Abbrev});

		Console.WriteLine($"GloassaryItem.GlossDef: {GloassaryItem.GlossDef});

		Console.WriteLine($"GloassaryItem.para: {GloassaryItem.para});

		Console.WriteLine($"GloassaryItem.GlossSeeAlso: {GloassaryItem.GlossSeeAlso});

		Console.WriteLine($"GloassaryItem.GlossSee: {GloassaryItem.GlossSee});


	}
}