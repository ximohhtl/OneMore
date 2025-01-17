﻿//************************************************************************************************
// Copyright © 2020 Steven M Cohn.  All rights reserved.
//************************************************************************************************

namespace River.OneMoreAddIn.Commands
{
	using System.Linq;
	using System.Threading.Tasks;

	internal class RemoveAuthorsCommand : Command
	{
		public RemoveAuthorsCommand()
		{
		}


		public override async Task Execute(params object[] args)
		{
			using var one = new OneNote(out var page, out var ns);
			logger.StartClock();

			var count = 0;

			// these are all the elements that might have editedByAttributes
			var elements = page.Root.Descendants().Where(d =>
				d.Name.LocalName == "Table" ||
				d.Name.LocalName == "Row" ||
				d.Name.LocalName == "Cell" ||
				d.Name.LocalName == "Outline" ||
				d.Name.LocalName == "OE")
				.ToList();

			foreach (var element in elements)
			{
				// editedByAttributes attributeGroup
				var atts = element.Attributes().Where(a =>
					a.Name == "author" ||
					a.Name == "authorInitials" ||
					a.Name == "authorResolutionID" ||
					a.Name == "lastModifiedBy" ||
					a.Name == "lastModifiedByInitials" ||
					a.Name == "lastModifiedByResolutionID"
					)
					.ToList();

				count += atts.Count;
				atts.ForEach(a => a.Remove());
			}

			logger.WriteTime("removed authors, now saving...");

			// TODO: This is removing authorship from OEs that wrap Images but
			// OneNote isn't saving those changes. I don't know why...

			if (count > 0)
			{
				logger.WriteLine($"cleaned {count} author attributes");
				await one.Update(page);
			}
		}
	}
}
