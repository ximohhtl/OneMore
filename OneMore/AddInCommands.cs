﻿//************************************************************************************************
// Copyright © 2016 Steven M Cohn.  All rights reserved.
//************************************************************************************************

#pragma warning disable CS3001      // Type is not CLS-compliant
#pragma warning disable IDE0060     // remove unused parameter
#pragma warning disable S1135       // Track uses of "TODO" tags

namespace River.OneMoreAddIn
{
	using Microsoft.Office.Core;
	using River.OneMoreAddIn.Commands;
	using System.Threading;
	using System.Threading.Tasks;
	using System.Windows.Forms;

	public partial class AddIn
	{
		public async Task AboutCmd(IRibbonControl control)
			=> await factory.Run<AboutCommand>();

		public async Task AddCaptionCmd(IRibbonControl control)
			=> await factory.Run<AddCaptionCommand>();


		[IgnorePalette]
		public void AddFavoritePageCmd(IRibbonControl control)
			=> new FavoritesProvider(ribbon).AddFavorite();


		[IgnorePalette]
		public void AddFavoriteSectionCmd(IRibbonControl control)
			=> new FavoritesProvider(ribbon).AddFavorite(true);


		[Command("ribAddFootnoteButton_Label", Keys.Control | Keys.Alt | Keys.F, "References")]
		public async Task AddFootnoteCmd(IRibbonControl control)
			=> await factory.Run<AddFootnoteCommand>();


		[Command("ribAddFormulaButton_Label", Keys.F5, "Tables")]
		public async Task AddFormulaCmd(IRibbonControl control)
			=> await factory.Run<AddFormulaCommand>();

		public async Task AddTitleIconCmd(IRibbonControl control)
			=> await factory.Run<AddTitleIconCommand>();

		public async Task AnalyzeCmd(IRibbonControl control)
			=> await factory.Run<AnalyzeCommand>();


		[Command("ribApplyStyle1Button_Label", Keys.Control | Keys.Alt | Keys.Shift | Keys.D1, "Styles")]
		public async Task ApplyStyle0Cmd(IRibbonControl control)
			=> await factory.Run<ApplyStyleCommand>(0);


		[Command("ribApplyStyle2Button_Label", Keys.Control | Keys.Alt | Keys.Shift | Keys.D2, "Styles")]
		public async Task ApplyStyle1Cmd(IRibbonControl control)
			=> await factory.Run<ApplyStyleCommand>(1);


		[Command("ribApplyStyle3Button_Label", Keys.Control | Keys.Alt | Keys.Shift | Keys.D3, "Styles")]
		public async Task ApplyStyle2Cmd(IRibbonControl control)
			=> await factory.Run<ApplyStyleCommand>(2);


		[Command("ribApplyStyle4Button_Label", Keys.Control | Keys.Alt | Keys.Shift | Keys.D4, "Styles")]
		public async Task ApplyStyle3Cmd(IRibbonControl control)
			=> await factory.Run<ApplyStyleCommand>(3);


		[Command("ribApplyStyle5Button_Label", Keys.Control | Keys.Alt | Keys.Shift | Keys.D5, "Styles")]
		public async Task ApplyStyle4Cmd(IRibbonControl control)
			=> await factory.Run<ApplyStyleCommand>(4);


		[Command("ribApplyStyle6Button_Label", Keys.Control | Keys.Alt | Keys.Shift | Keys.D6, "Styles")]
		public async Task ApplyStyle5Cmd(IRibbonControl control)
			=> await factory.Run<ApplyStyleCommand>(5);


		[Command("ribApplyStyle7Button_Label", Keys.Control | Keys.Alt | Keys.Shift | Keys.D7, "Styles")]
		public async Task ApplyStyle6Cmd(IRibbonControl control)
			=> await factory.Run<ApplyStyleCommand>(6);


		[Command("ribApplyStyle8Button_Label", Keys.Control | Keys.Alt | Keys.Shift | Keys.D8, "Styles")]
		public async Task ApplyStyle7Cmd(IRibbonControl control)
			=> await factory.Run<ApplyStyleCommand>(7);


		[Command("ribApplyStyle9Button_Label", Keys.Control | Keys.Alt | Keys.Shift | Keys.D9, "Styles")]
		public async Task ApplyStyle8Cmd(IRibbonControl control)
			=> await factory.Run<ApplyStyleCommand>(8);


		public async Task ApplyStyleCmd(IRibbonControl control, string selectedId, int selectedIndex)
			=> await factory.Run<ApplyStyleCommand>(selectedIndex);

		public async Task ApplyStylesCmd(IRibbonControl control)
			=> await factory.Run<ApplyStylesCommand>();

		public async Task ArchiveCmd(IRibbonControl control)
			=> await factory.Run<ArchiveCommand>(control.Tag); // tag=scope

		public async Task ArrangeContainersCmd(IRibbonControl control)
			=> await factory.Run<ArrangeContainersCommand>();

		public async Task BreakingCmd(IRibbonControl control)
			=> await factory.Run<BreakingCommand>();


		[Command("ribCalendarButton_Label", Keys.None, "Tools")]
		public async Task CalendarCmd(IRibbonControl control)
			=> await factory.Run<CalendarCommand>();


		public async Task CaptionAttachmentsCmd(IRibbonControl control)
			=> await factory.Run<CaptionAttachmentsCommand>();

		public async Task ChangePageColorCmd(IRibbonControl control)
			=> await factory.Run<ChangePageColorCommand>();

		[Command("ribChooseFavoriteButton_Label", Keys.Alt | Keys.F, "Tools")]
		public async Task ChooseFavoriteCmd(IRibbonControl control)
			=> await factory.Run<GotoFavoriteCommand>(null);

		public async Task ClearBackgroundCmd(IRibbonControl control)
			=> await factory.Run<ClearBackgroundCommand>();


		[Command("ribClearLogButton_Label", Keys.Control | Keys.F8, "Tools")]
		public async Task ClearLogCmd(IRibbonControl control)
			=> await factory.Run<ClearLogCommand>();


		public async Task CollapsePagesCmd(IRibbonControl control)
			=> await factory.Run<CollapsePagesCommand>();

		public async Task CollapseContentCmd(IRibbonControl control)
			=> await factory.Run<ExpandoCommand>(Expando.Collapse);

		public async Task ColorizeCmd(IRibbonControl control)
			=> await factory.Run<ColorizeCommand>(control.Tag); // tag=language


		[Command("ribCommandPaletteButton_Label", Keys.Control | Keys.Shift | Keys.P, "")]
		public async Task CommandPaletteCmd(IRibbonControl control)
			=> await factory.Run<CommandPaletteCommand>();

		public async Task CompleteReminderCmd(IRibbonControl control)
			=> await factory.Run<CompleteReminderCommand>();

		public async Task CopyAcrossCmd(IRibbonControl control)
			=> await factory.Run<FillCellsCommand>(FillCells.CopyAcross);

		public async Task CopyDownCmd(IRibbonControl control)
			=> await factory.Run<FillCellsCommand>(FillCells.CopyDown);

		public async Task CopyFolderCmd(IRibbonControl control)
			=> await factory.Run<CopyFolderCommand>();


		[Command("ribCopyLinkToPageButton_Label", Keys.None, "References")]
		public async Task CopyLinkToPageCmd(IRibbonControl control)
			=> await factory.Run<CopyLinkCommand>(false);


		[Command("ribCopyLinkToParagraphButton_Label", Keys.None, "References")]
		public async Task CopyLinkToParagraphCmd(IRibbonControl control)
			=> await factory.Run<CopyLinkCommand>(true);

		public async Task CrawlWebPageCmd(IRibbonControl control)
			=> await factory.Run<CrawlWebPageCommand>();

		public async Task CreatePagesCmd(IRibbonControl control)
			=> await factory.Run<CreatePagesCommand>();

		public async Task CropImageCmd(IRibbonControl control)
			=> await factory.Run<CropImageCommand>();

		public async Task DateStampCmd(IRibbonControl control)
			=> await factory.Run<DateStampCommand>();


		[Command("ribDecreaseFontSizeButton_Label", Keys.Control | Keys.Alt | Keys.OemMinus, "Editing")]
		public async Task DecreaseFontSizeCmd(IRibbonControl control)
			=> await factory.Run<AlterSizeCommand>(-1);


		public async Task DeleteFormulaCmd(IRibbonControl control)
			=> await factory.Run<DeleteFormulaCommand>();

		public async Task DeleteReminderCmd(IRibbonControl control)
			=> await factory.Run<DeleteReminderCommand>();


		[Command("ribDiagnosticsButton_Label", Keys.Shift | Keys.F8, "Tools")]
		public async Task DiagnosticsCmd(IRibbonControl control)
			=> await factory.Run<DiagnosticsCommand>();


		[Command("ribDisableSpellCheckButton_Label", Keys.F4, "Editing")]
		public async Task DisableSpellCheckCmd(IRibbonControl control)
			=> await factory.Run<ProofingCommand>(ProofingCommand.NoLang);


		public async Task EditStylesCmd(IRibbonControl control)
			=> await factory.Run<EditStylesCommand>();

		public async Task EmbedSubpageCmd(IRibbonControl control)
			=> await factory.Run<EmbedSubpageCommand>(false);

		public async Task EnableSpellCheckCmd(IRibbonControl control)
			=> await factory.Run<ProofingCommand>(Thread.CurrentThread.CurrentUICulture.Name);

		public async Task ExpandContentCmd(IRibbonControl control)
			=> await factory.Run<ExpandoCommand>(Expando.Expand);


		[Command("ribExpandSnippetButton_Label", Keys.Alt | Keys.F3, "Snippets")]
		public async Task ExpandSnippetCmd(IRibbonControl control)
			=> await factory.Run<InsertSnippetCommand>(string.Empty);


		public async Task ExportCmd(IRibbonControl control)
			=> await factory.Run<ExportCommand>();

		public async Task FillAcrossCmd(IRibbonControl control)
			=> await factory.Run<FillCellsCommand>(FillCells.FillAcross);


		[Command("ribFillDownButton_Label", Keys.Control | Keys.D, "Tables")]
		public async Task FillDownCmd(IRibbonControl control)
			=> await factory.Run<FillCellsCommand>(FillCells.FillDown);


		public async Task FinishBiLinkCmd(IRibbonControl control)
			=> await factory.Run<BiLinkCommand>("link");

		public async Task FitGridToTextCmd(IRibbonControl control)
			=> await factory.Run<FitGridToTextCommand>();

		public async Task GetImagesCmd(IRibbonControl control)
			=> await factory.Run<GetImagesCommand>(true);

		public async Task GotoFavoriteCmd(IRibbonControl control)
			=> await factory.Run<GotoFavoriteCommand>(control.Tag); //tag=pageid


		[Command("ribHighlightButton_Label", Keys.Control | Keys.Shift | Keys.H, "Editing")]
		public async Task HighlightCmd(IRibbonControl control)
			=> await factory.Run<HighlightCommand>();


		public async Task HighlightFormulaCmd(IRibbonControl control)
			=> await factory.Run<HighlightFormulaCommand>();


		public async Task ImportOutlookTasksCmd(IRibbonControl control)
			=> await factory.Run<ImportOutlookTasksCommand>();


		[Command("ribIncreaseFontSizeButton_Label", Keys.Control | Keys.Alt | Keys.Oemplus, "Editing")]
		public async Task IncreaseFontSizeCmd(IRibbonControl control)
			=> await factory.Run<AlterSizeCommand>(1);


		public async Task ImportCmd(IRibbonControl control)
			=> await factory.Run<ImportCommand>();

		public async Task ImportWebCmd(IRibbonControl control)
			=> await factory.Run<ImportWebCommand>();

		public async Task InsertBlueStatusCmd(IRibbonControl control)
			=> await factory.Run<InsertStatusCommand>(StatusColor.Blue);


		[Command("ribInsertBoxButton_Label", Keys.None, "Snippets")]
		public async Task InsertBoxCmd(IRibbonControl control)
			=> await factory.Run<InsertCodeBlockCommand>(false);


		public async Task InsertBreadcrumbCmd(IRibbonControl control)
			=> await factory.Run<InsertBreadcrumbCommand>(StatusColor.Blue);

		public async Task InsertCalendarCmd(IRibbonControl control)
			=> await factory.Run<InsertCalendarCommand>();

		public async Task InsertCellsCmd(IRibbonControl control)
			=> await factory.Run<InsertCellsCommand>();


		[Command("ribInsertCodeBlockButton_Label", Keys.F6, "Snippets")]
		public async Task InsertCodeBlockCmd(IRibbonControl control)
			=> await factory.Run<InsertCodeBlockCommand>(true);


		[Command("ribInsertDateButton_Label", Keys.Control | Keys.Shift | Keys.D, "Snippets")]
		public async Task InsertDateCmd(IRibbonControl control)
			=> await factory.Run<InsertDateCommand>(false);


		[Command("ribInsertDateTimeButton_Label", Keys.Control | Keys.Shift | Keys.Alt | Keys.D, "Snippets")]
		public async Task InsertDateTimeCmd(IRibbonControl control)
			=> await factory.Run<InsertDateCommand>(true);


		[Command("ribInsertDoubleLineButton_Label", Keys.Alt | Keys.Shift| Keys.F12, "Snippets")]
		public async Task InsertDoubleLineCmd(IRibbonControl control)
			=> await factory.Run<InsertLineCommand>('═');


		public async Task InsertExpandCmd(IRibbonControl control)
			=> await factory.Run<InsertExpandCommand>();

		public async Task InsertGrayStatusCmd(IRibbonControl control)
			=> await factory.Run<InsertStatusCommand>(StatusColor.Gray);

		public async Task InsertGreenStatusCmd(IRibbonControl control)
			=> await factory.Run<InsertStatusCommand>(StatusColor.Green);

		public async Task InsertInfoBlockCmd(IRibbonControl control)
			=> await factory.Run<InsertInfoBlockCommand>(false);

		public async Task InsertQRCmd(IRibbonControl control)
			=> await factory.Run<InsertQRCommand>(false);

		public async Task InsertRedStatusCmd(IRibbonControl control)
			=> await factory.Run<InsertStatusCommand>(StatusColor.Red);


		[Command("ribInsertSingleLineButton_Label", Keys.Alt | Keys.Shift | Keys.F11, "Snippets")]
		public async Task InsertSingleLineCmd(IRibbonControl control)
			=> await factory.Run<InsertLineCommand>('─');


		public async Task InsertSnippetCmd(IRibbonControl control)
			=> await factory.Run<InsertSnippetCommand>(control.Tag); // tag=filepath


		[Command("ribInsertTimerButton_Label", Keys.F2, "Extras")]
		public async Task InsertTimerCmd(IRibbonControl control)
			=> await factory.Run<TimerWindowCommand>(true);


		public async Task InsertTocCmd(IRibbonControl control)
			=> await factory.Run<InsertTocCommand>();

		public async Task InsertWarnBlockCmd(IRibbonControl control)
			=> await factory.Run<InsertInfoBlockCommand>(true);

		public async Task InsertYellowStatusCmd(IRibbonControl control)
			=> await factory.Run<InsertStatusCommand>(StatusColor.Yellow);

		public async Task InvertSelectionCmd(IRibbonControl control)
			=> await factory.Run<InvertSelectionCommand>();

		public async Task JoinParagraphCmd(IRibbonControl control)
			=> await factory.Run<JoinParagraphCommand>();

		public async Task LinkReferencesCmd(IRibbonControl control)
			=> await factory.Run<LinkReferencesCommand>();

		public async Task LoadStylesCmd(IRibbonControl control)
			=> await factory.Run<LoadStylesCommand>();

		public async Task ManageFavoritesCmd(IRibbonControl control)
			=> await factory.Run<ManageFavoritesCommand>(ribbon);

		public async Task ManagePluginsCmd(IRibbonControl control)
			=> await factory.Run<ManagePluginsCommand>(ribbon);

		public async Task ManageSnippetsCmd(IRibbonControl control)
			=> await factory.Run<ManageSnippetsCommand>(ribbon);

		public async Task MapCmd(IRibbonControl control)
			=> await factory.Run<MapCommand>();

		public async Task MergeCmd(IRibbonControl control)
			=> await factory.Run<MergeCommand>();

		public async Task NameUrlsCmd(IRibbonControl control)
			=> await factory.Run<NameUrlsCommand>();

		public async Task NewStyleCmd(IRibbonControl control)
			=> await factory.Run<NewStyleCommand>();

		public async Task NumberPagesCmd(IRibbonControl control)
			=> await factory.Run<NumberPagesCommand>();

		public async Task NumberSectionsCmd(IRibbonControl control)
			=> await factory.Run<NumberSectionsCommand>();


		[Command("ribOpenLogButton_Label", Keys.None, "Tools")]
		public async Task OpenLogCmd(IRibbonControl control)
			=> await factory.Run<OpenLogCommand>();


		public async Task OutlineCmd(IRibbonControl control)
			=> await factory.Run<OutlineCommand>();

		public async Task PasteCellsCmd(IRibbonControl control)
			=> await factory.Run<PasteCellsCommand>();


		[Command("ribPasteRtfButton_Label", Keys.Control | Keys.Alt | Keys.V, "Editing")]
		public async Task PasteRtfCmd(IRibbonControl control)
			=> await factory.Run<PasteRtfCommand>();


		[Command("ribPasteTextButton_Label", Keys.Control | Keys.Shift | Keys.V, "Editing")]
		public async Task PasteTextCmd(IRibbonControl control)
			=> await factory.Run<PasteTextCommand>();


		public async Task PronunciateCmd(IRibbonControl control)
			=> await factory.Run<PronunciateCommand>();


		[Command("ribRecalculateFormulaButton_Label", Keys.Shift | Keys.F5, "Tables")]
		public async Task RecalculateFormulaCmd(IRibbonControl control)
			=> await factory.Run<RecalculateFormulaCommand>();


		public async Task RefreshFootnotesCmd(IRibbonControl control)
			=> await factory.Run<RefreshFootnotesCommand>();

		public async Task RefreshPageLinksCmd(IRibbonControl control)
			=> await factory.Run<RefreshPageLinksCommand>();


		[Command("ribRemindButton_Label", Keys.F8, "Extras")]
		public async Task RemindCmd(IRibbonControl control)
			=> await factory.Run<RemindCommand>();


		public async Task RemoveAuthorsCmd(IRibbonControl control)
			=> await factory.Run<RemoveAuthorsCommand>();

		public async Task RemoveCitationsCmd(IRibbonControl control)
			=> await factory.Run<RemoveCitationsCommand>();


		[Command("ribRemoveDuplicatesButton_Label", Keys.None, "Clean")]
		public async Task RemoveDuplicatesCmd(IRibbonControl control)
			=> await factory.Run<RemoveDuplicatesCommand>();


		public async Task RemoveEmptyCmd(IRibbonControl control)
			=> await factory.Run<RemoveEmptyCommand>();


		[Command("ribRemoveFootnoteButton_Label", Keys.Control | Keys.Shift | Keys.F, "References")]
		public async Task RemoveFootnoteCmd(IRibbonControl control)
			=> await factory.Run<RemoveFootnoteCommand>();


		public async Task RemoveInkCmd(IRibbonControl control)
			=> await factory.Run<RemoveInkCommand>();

		public async Task RemovePageNumbersCmd(IRibbonControl control)
			=> await factory.Run<RemovePageNumbersCommand>();

		public async Task RemoveSectionNumbersCmd(IRibbonControl control)
			=> await factory.Run<RemoveSectionNumbersCommand>();

		public async Task RemoveSpacingCmd(IRibbonControl control)
			=> await factory.Run<RemoveSpacingCommand>();

		public async Task RemoveTagsCmd(IRibbonControl control)
			=> await factory.Run<RemoveTagsCommand>();


		[Command("ribReplayButton_Label", Keys.Alt | Keys.Shift | Keys.R, "")]
		public async Task ReplayCmd(IRibbonControl control)
			=> await factory.ReplayLastAction();


		public async Task ReportRemindersCmd(IRibbonControl control)
			=> await factory.Run<ReportRemindersCommand>();

		public async Task ResizeImagesCmd(IRibbonControl control)
			=> await factory.Run<ResizeImagesCommand>();

		public async Task RestoreAutosizeCmd(IRibbonControl control)
			=> await factory.Run<RestoreAutosizeCommand>();

		public async Task RestoreCollapsedCmd(IRibbonControl control)
			=> await factory.Run<ExpandoCommand>(Expando.Restore);

		public async Task RunPluginCmd(IRibbonControl control)
			=> await factory.Run<RunPluginCommand>(control.Tag); // tag=plugin

		public async Task SaveCollapsedCmd(IRibbonControl control)
			=> await factory.Run<ExpandoCommand>(Expando.Save);

		public async Task SaveSnippetCmd(IRibbonControl control)
			=> await factory.Run<SaveSnippetCommand>();


		[Command("ribSearchButton_Label", Keys.None, "Search")]
		public async Task SearchCmd(IRibbonControl control)
			=> await factory.Run<SearchCommand>();


		[Command("ribSearchAndReplaceButton_Label", Keys.Control | Keys.H, "Search")]
		public async Task SearchAndReplaceCmd(IRibbonControl control)
			=> await factory.Run<SearchAndReplaceCommand>();


		public async Task SearchWebCmd(IRibbonControl control)
			=> await factory.Run<SearchWebCommand>(control.Tag); // tag=engine

		public async Task SectionColorCmd(IRibbonControl control)
			=> await factory.Run<SectionColorCommand>();

		public async Task SelectImagesCmd(IRibbonControl control)
			=> await factory.Run<SelectImagesCommand>();

		public async Task SelectStyleCmd(IRibbonControl control)
			=> await factory.Run<SelectStyleCommand>();

		public async Task SetProofingCmd(IRibbonControl control)
			=> await factory.Run<ProofingCommand>(control.Tag); // tag=language

		public async Task SettingsCmd(IRibbonControl control)
			=> await factory.Run<SettingsCommand>(ribbon);

		public async Task ShowKeyboardShortcutsCmd(IRibbonControl control)
			=> await factory.Run<ShowKeyboardShortcutsCommand>();


		[Command("ribShowXmlButton_Label", Keys.Control | Keys.Alt | Keys.Shift | Keys.X, "Tools")]
		public async Task ShowXmlCmd(IRibbonControl control)
			=> await factory.Run<ShowXmlCommand>();


		public async Task SortCmd(IRibbonControl control)
			=> await factory.Run<SortCommand>();

		public async Task SortListCmd(IRibbonControl control)
			=> await factory.Run<SortListCommand>();

		public async Task SortPageCmd(IRibbonControl control)
			=> await factory.Run<SortCommand>(OneNote.Scope.Children);

		public async Task SortPagesCmd(IRibbonControl control)
			=> await factory.Run<SortCommand>(OneNote.Scope.Pages);

		public async Task SortSectionsCmd(IRibbonControl control)
			=> await factory.Run<SortCommand>(OneNote.Scope.Sections);

		public async Task SortNotebooksCmd(IRibbonControl control)
			=> await factory.Run<SortCommand>(OneNote.Scope.Notebooks);

		public async Task SplitCmd(IRibbonControl control)
			=> await factory.Run<SplitCommand>();

		public async Task SplitTableCmd(IRibbonControl control)
			=> await factory.Run<SplitTableCommand>();

		public async Task StartBiLinkCmd(IRibbonControl control)
			=> await factory.Run<BiLinkCommand>("mark");


		[Command("ribStartTimerButton_Label", Keys.Alt | Keys.F2, "Extras")]
		public async Task StartTimerCmd(IRibbonControl control)
			=> await factory.Run<TimerWindowCommand>();


		public async Task StrikeoutTasksCmd(IRibbonControl control)
			=> await factory.Run<StrikeoutTasksCommand>();


		[Command("ribTaggedButton_Label", Keys.Control | Keys.Alt | Keys.T, "Search")]
		public async Task TaggedCmd(IRibbonControl control)
			=> await factory.Run<TaggedCommand>();


		[Command("ribTaggingButton_Label", Keys.Alt | Keys.T, "Search")]
		public async Task TaggingCmd(IRibbonControl control)
			=> await factory.Run<TaggingCommand>();


		public async Task TextToTableCmd(IRibbonControl control)
			=> await factory.Run<TextToTableCommand>();


		[Command("ribLowercaseButton_Label", Keys.Control | Keys.Shift | Keys.U, "Editing")]
		public async Task LowercaseCmd(IRibbonControl control)
			=> await factory.Run<ToCaseCommand>(ToCaseCommand.Lowercase);


		public async Task ToggleDttmCmd(IRibbonControl control)
			=> await factory.Run<ToggleDttmCommand>();

		public async Task TitlecaseCmd(IRibbonControl control)
			=> await factory.Run<ToCaseCommand>(ToCaseCommand.Titlecase);

		public async Task TrimCmd(IRibbonControl control)
			=> await factory.Run<TrimCommand>(false);

		public async Task TrimLeadingCmd(IRibbonControl control)
			=> await factory.Run<TrimCommand>(true);

		public async Task UpdateSubpageCmd(IRibbonControl control)
			=> await factory.Run<EmbedSubpageCommand>(true);


		[Command("ribUppercaseButton_Label", Keys.Control | Keys.Alt | Keys.Shift | Keys.U, "Editing")]
		public async Task UppercaseCmd(IRibbonControl control)
			=> await factory.Run<ToCaseCommand>(ToCaseCommand.Uppercase);


		public async Task WordCountCmd(IRibbonControl control)
			=> await factory.Run<WordCountCommand>();
	}
}
