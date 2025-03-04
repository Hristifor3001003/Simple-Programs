object Form1: TForm1
  Left = 192
  Top = 125
  Width = 642
  Height = 315
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object ListBox1: TListBox
    Left = 208
    Top = 16
    Width = 376
    Height = 241
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -15
    Font.Name = 'Arial Rounded MT Bold'
    Font.Style = []
    ItemHeight = 17
    ParentFont = False
    TabOrder = 0
  end
  object ElapsedTimeButton: TButton
    Left = 32
    Top = 96
    Width = 153
    Height = 73
    Caption = 'Elapsed Time'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Arial Rounded MT Bold'
    Font.Style = []
    ParentFont = False
    TabOrder = 1
    OnClick = ElapsedTimeButtonClick
  end
end
