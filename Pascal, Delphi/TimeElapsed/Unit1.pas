unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    ListBox1: TListBox;
    ElapsedTimeButton: TButton;
    procedure FormCreate(Sender: TObject);
    procedure ElapsedTimeButtonClick(Sender: TObject);
  private
    StartTime: TDateTime;
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.FormCreate(Sender: TObject);
var
  FormatDate, FormatTime: string;
begin
   StartTime := Now;
   FormatDate := FormatDateTime('yyyy-mm-dd', StartTime);
   FormatTime := FormatDateTime('hh:nn:ss', StartTime);

   ListBox1.Items.Add(FormatTime);
   ListBox1.Items.Add(FormatDate);
   ListBox1.Items.Add('Press button for elapsed time');

end;

procedure TForm1.ElapsedTimeButtonClick(Sender: TObject);
var
  StopTime: TDateTime;
begin
  StopTime := Now;
  ListBox1.Items[2] := FormatDateTime('hh:nn:ss:zzz', StopTime - StartTime);
end;

end.
