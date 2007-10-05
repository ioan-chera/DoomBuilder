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
OutputBaseFilename=builder2_setup
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
Source: d3dx9_35.dll; DestDir: {app}; Flags: ignoreversion
Source: SlimDX.dll; DestDir: {app}; Flags: ignoreversion
Source: Builder.cfg; DestDir: {app}; Flags: ignoreversion
Source: Compilers\*; DestDir: {app}\Compilers; Flags: ignoreversion
Source: Configurations\*; DestDir: {app}\Configurations; Flags: ignoreversion
Source: Scripting\*; DestDir: {app}\Scripting; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: {group}\Doom Builder; Filename: {app}\Builder.exe
Name: {group}\{cm:UninstallProgram,Doom Builder}; Filename: {uninstallexe}
Name: {commondesktop}\Doom Builder; Filename: {app}\Builder.exe; Tasks: desktopicon

[Run]
Filename: {app}\Builder.exe; Description: {cm:LaunchProgram,Doom Builder}; Flags: nowait postinstall skipifsilent

[UninstallDelete]
Name: {app}\Builder.log; Type: files
