; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
AppName=Doom Builder 2
AppVerName=Doom Builder 2.0
AppPublisher=CodeImp
AppPublisherURL=http://www.codeimp.com/
AppSupportURL=http://www.doombuilder.com/
AppUpdatesURL=http://www.doombuilder.com/
DefaultDirName={pf}\Doom Builder 2
DefaultGroupName=Doom Builder
AllowNoIcons=true
InfoBeforeFile=E:\Projects\Doom Builder\Setup\disclaimer.txt
OutputDir=E:\Projects\Doom Builder\Setup
OutputBaseFilename=builder2debug_setup
Compression=lzma/ultra64
SolidCompression=true
SourceDir=E:\Projects\Doom Builder\Build
SetupLogging=false
AppMutex=doombuilder2
PrivilegesRequired=poweruser
ShowLanguageDialog=no

[Languages]
Name: english; MessagesFile: compiler:Default.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

[Files]
Source: Builder.exe; DestDir: {app}; Flags: ignoreversion
Source: Builder.cfg; DestDir: {app}; Flags: ignoreversion
Source: Builder.pdb; DestDir: {app}; Flags: ignoreversion
Source: SlimDX.dll; DestDir: {app}; Flags: ignoreversion
Source: Sharpzip.dll; DestDir: {app}; Flags: ignoreversion
Source: msvcr80.dll; DestDir: {app}; Flags: ignoreversion
Source: msvcp80.dll; DestDir: {app}; Flags: ignoreversion
Source: msvcm80.dll; DestDir: {app}; Flags: ignoreversion
Source: Compilers\*; DestDir: {app}\Compilers; Flags: ignoreversion
Source: Configurations\*; DestDir: {app}\Configurations; Flags: ignoreversion
Source: Scripting\*; DestDir: {app}\Scripting; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: Plugins\*; DestDir: {app}\Plugins; Flags: ignoreversion
Source: Setup\*; DestDir: {app}\Setup; Flags: ignoreversion

[Icons]
Name: {group}\Doom Builder; Filename: {app}\Builder.exe
Name: {group}\{cm:UninstallProgram,Doom Builder}; Filename: {uninstallexe}
Name: {commondesktop}\Doom Builder; Filename: {app}\Builder.exe; Tasks: desktopicon

[Run]

[UninstallDelete]
Name: {localappdata}\Doom Builder; Type: files
[Code]
// Global variables
var
	page_info_dx: TOutputMsgWizardPage;
	page_setup_dx: TOutputProgressWizardPage;
	page_info_net: TOutputMsgWizardPage;
	page_setup_net: TOutputProgressWizardPage;




// When the wizard initializes
procedure InitializeWizard();
begin
	// Make custom pages
	page_info_dx := CreateOutputMsgPage(wpInstalling, 'Installing Microsoft DirectX', '', 'Setup will now start the installation and/or update of your Microsoft DirectX version. Press Next to begin.');
	page_setup_dx := CreateOutputProgressPage('Installing Microsoft DirectX', 'Setup is installing Microsoft DirectX, please wait...');
	page_info_net := CreateOutputMsgPage(page_info_dx.ID, 'Installing Microsoft .NET Framework', '', 'Setup will now start the installation and/or update of your Microsoft .NET Framework. Press Next to begin.');
	page_setup_net := CreateOutputProgressPage('Installing Microsoft .NET Framework', 'Setup is installing Microsoft.NET Framework, please wait...');
end;



// This is called to check if a page must be skipped
function ShouldSkipPage(PageID: Integer): Boolean;
begin
	// Skip the .NET page?
	if(PageID = page_info_net.ID) then
		Result := RegKeyExists(HKLM, 'SOFTWARE\Microsoft\.NETFramework\policy\v2.0')
	else
		Result := False;
end;


// This is called when the Next button is clicked
function NextButtonClick(CurPage: Integer): Boolean;
var
	ErrorCode: Integer;
begin

	// Next pressed on DX info page?
	if(CurPage = page_info_dx.ID) then
	begin
		// Show progress page and run setup
		page_setup_dx.Show;
		try
			ShellExec('open', ExpandConstant('{app}\Setup\dxwebsetup.exe'), '', '/Q', SW_SHOW, ewWaitUntilTerminated, ErrorCode);
		finally
			page_setup_dx.Hide;
		end;
	end

	// Next pressed on .NET info page?
	if(CurPage = page_info_net.ID) then
	begin
		// Show progress page and run setup
		page_setup_net.Show;
		try
			ShellExec('open', ExpandConstant('{app}\Setup\dotnetfx35setup.exe'), '', '/noreboot', SW_SHOW, ewWaitUntilTerminated, ErrorCode);
		finally
			page_setup_net.Hide;
		end;
	end

	Result := True;
end;




[Registry]
Root: HKLM; Subkey: SOFTWARE\CodeImp\Doom Builder\; ValueType: string; ValueName: Location; ValueData: {app}; Flags: uninsdeletevalue


