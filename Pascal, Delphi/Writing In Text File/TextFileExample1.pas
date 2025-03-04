unit TextFileExample1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    Label1: TLabel;
    Button1: TButton;
    Label2: TLabel;
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}


procedure TForm1.Button1Click(Sender: TObject);
var MyFile: TextFile;
begin
  // Assign the file name to the TextFile variable
  AssignFile(MyFile, 'example.txt');

  // Open the file for writing (creates or overwrites the file)
  Rewrite(MyFile);

  // Write some text to a file
  Writeln(MyFile, 'First Line');
  Writeln(MyFile, 'Second Line');
  Writeln(MyFile, 'Third Line');

  // Close the file after writing
  CloseFile(MyFile);

  Label2.Caption := 'Program has ended. Text is written in the file example.txt';
end;

end.
