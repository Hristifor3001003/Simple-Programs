program Example3AppendProject;

uses
  Forms,
  Example3Append in 'Example3Append.pas' {Form1};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
