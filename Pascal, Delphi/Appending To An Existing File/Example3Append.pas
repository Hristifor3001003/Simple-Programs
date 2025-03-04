unit Example3Append;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    Label1: TLabel;
    Button1: TButton;
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
var MyFile: TextFile;
    Text: WideString;
    Line: WideString;
begin
  Text := 'The current contents in the file is: ' + sLineBreak + sLineBreak;

  AssignFile(MyFile, 'example.txt');
  Append(MyFile);

  WriteLn(MyFile, 'This line is appended in the file.' + sLineBreak);
  CloseFile(MyFile);

  Reset(MyFile);

  while (not(Eof(MyFile))) do
  begin
    Readln(MyFile, Line);
    Text := Text + Line + sLineBreak;
  end;

  CloseFile(MyFile);

  Label1.Caption := Text;

end;

end.
