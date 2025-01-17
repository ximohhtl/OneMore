﻿//************************************************************************************************
// Copyright © 2020 Steven M Cohn.  All rights reserved.
//************************************************************************************************

namespace River.OneMoreAddIn.Commands
{
	using Microsoft.Office.Core;
	using River.OneMoreAddIn.Settings;
	using System.Threading.Tasks;

	internal class ManageSnippetsCommand : Command
	{
		public ManageSnippetsCommand()
		{
		}


		public override async Task Execute(params object[] args)
		{
			using (var dialog = new SettingsDialog(args[0] as IRibbonUI))
			{
				dialog.ActivateSheet(SettingsDialog.Sheets.Snippets);
				dialog.ShowDialog();
			}

			await Task.Yield();
		}
	}
}