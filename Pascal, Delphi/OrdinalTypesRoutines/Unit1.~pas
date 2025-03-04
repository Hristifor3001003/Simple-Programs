unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    Label1: TLabel;
    InputNumber: TEdit;
    DecButton: TButton;
    IncButton: TButton;
    OddButton: TButton;
    PredButton: TButton;
    SuccButton: TButton;
    OrdButton: TButton;
    ResetButton: TButton;
    Label2: TLabel;
    Label3: TLabel;
    procedure ResetButtonClick(Sender: TObject);
    procedure DecButtonClick(Sender: TObject);
    procedure IncButtonClick(Sender: TObject);
    procedure OddButtonClick(Sender: TObject);
    procedure PredButtonClick(Sender: TObject);
    procedure SuccButtonClick(Sender: TObject);
    procedure OrdButtonClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  FNumber: Int64;

implementation

{$R *.dfm}

procedure TForm1.ResetButtonClick(Sender: TObject);
begin
  InputNumber.Text := '';
  Label3.Caption := '';
  FNumber := 0;
end;

procedure TForm1.DecButtonClick(Sender: TObject);
  var numberAsText: string;
      code: Integer;
begin
  numberAsText := InputNumber.Text;
  val(numberAsText, FNumber, code);
  Label3.Caption := '';

  if(code <> 0) then
  begin
    ShowMessage('You should enter valid integer from ' + IntToStr(Low(Int64)) + ' to ' + IntToStr(High(Int64)));
    InputNumber.Text := '';
    Label3.Caption := '';
  end
  else
  begin
    Dec(FNumber);
    Label3.Caption := IntToStr(FNumber);
  end;

end;

procedure TForm1.IncButtonClick(Sender: TObject);
var NumberAsText: string;
    code: Integer;
begin
  NumberAsText := InputNumber.Text;
  val(NumberAsText, FNumber, code);

  if(code <> 0) then
  begin
    ShowMessage('You should enter valid integer from ' + IntToStr(Low(Int64)) + ' to ' + IntToStr(High(Int64)));
    InputNumber.Text := '';
    Label3.Caption := '';
  end
  else
  begin
    Inc(FNumber);
    Label3.Caption := IntToStr(FNumber);
  end;
end;

procedure TForm1.OddButtonClick(Sender: TObject);
var NumberAsText: string;
    code: Integer;
begin
  NumberAsText := InputNumber.Text;
  val(NumberAsText, FNumber, code);

  if(code <> 0) then
  begin
    ShowMessage('You should enter valid integer from ' + IntToStr(Low(Int64)) + ' to ' + IntToStr(High(Int64)));
    InputNumber.Text := '';
    Label3.Caption := '';
  end
  else
  begin
    if (Odd(FNumber)) then
    begin
      Label3.Caption := NumberAsText + ' is an odd number.';
    end
    else
    begin
      Label3.Caption := NumberAsText + ' is not an odd number, i.e. it is an even number.';
    end;
  end;
end;

procedure TForm1.PredButtonClick(Sender: TObject);
var NumberAsText: string;
    code: Integer;
begin
  NumberAsText := InputNumber.Text;
  val(NumberAsText, FNumber, code);

  if(code <> 0) then
  begin
    ShowMessage('You should enter valid integer from ' + IntToStr(Low(Int64)) + ' to ' + IntToStr(High(Int64)));
    InputNumber.Text := '';
    Label3.Caption := '';
  end
  else
  begin
    Label3.Caption := IntToStr(Pred(FNumber));
  end;
end;
procedure TForm1.SuccButtonClick(Sender: TObject);
var NumberAsText: string;
    code: Integer;
begin
  NumberAsText := InputNumber.Text;
  val(NumberAsText, FNumber, code);

  if(code <> 0) then
  begin
    ShowMessage('You should enter valid integer from ' + IntToStr(Low(Int64)) + ' to ' + IntToStr(High(Int64)));
    InputNumber.Text := '';
    Label3.Caption := '';
  end
  else
  begin
    Label3.Caption := IntToStr(Succ(FNumber));
  end;
end;

procedure TForm1.OrdButtonClick(Sender: TObject);
var NumberAsText: string;
    code: Integer;
begin
  NumberAsText := InputNumber.Text;
  val(NumberAsText, FNumber, code);

  if(code <> 0) then
  begin
    ShowMessage('You should enter valid integer from ' + IntToStr(Low(Int64)) + ' to ' + IntToStr(High(Int64)));
    InputNumber.Text := '';
    Label3.Caption := '';
  end
  else
  begin
    Label3.Caption := IntToStr(Ord(FNumber));
  end;
end;

end.
