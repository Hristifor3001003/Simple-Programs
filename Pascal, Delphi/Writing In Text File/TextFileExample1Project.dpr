program TextFileExample1Project;

uses
  Forms,
  TextFileExample1 in 'TextFileExample1.pas' {Form1};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
