object Form1: TForm1
  Left = 192
  Top = 125
  Width = 1305
  Height = 408
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 24
    Top = 72
    Width = 625
    Height = 25
    Caption = 
      'Enter one integer number in the range from -(2^63) to 2^63 - 1 :' +
      ' '
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = '@Arial Unicode MS'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label2: TLabel
    Left = 560
    Top = 240
    Width = 78
    Height = 25
    Caption = 'Result : '
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = '@Arial Unicode MS'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label3: TLabel
    Left = 648
    Top = 240
    Width = 480
    Height = 25
    Caption = 
      '                                                                ' +
      '                '
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = '@Arial Unicode MS'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object InputNumber: TEdit
    Left = 664
    Top = 72
    Width = 297
    Height = 33
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = '@Arial Unicode MS'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 0
  end
  object DecButton: TButton
    Left = 104
    Top = 192
    Width = 97
    Height = 41
    Caption = 'Dec'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = '@Arial Unicode MS'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 1
    OnClick = DecButtonClick
  end
  object IncButton: TButton
    Left = 224
    Top = 192
    Width = 97
    Height = 41
    Caption = 'Inc'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = '@Arial Unicode MS'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 2
    OnClick = IncButtonClick
  end
  object OddButton: TButton
    Left = 352
    Top = 192
    Width = 97
    Height = 41
    Caption = 'Odd'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = '@Arial Unicode MS'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 3
    OnClick = OddButtonClick
  end
  object PredButton: TButton
    Left = 104
    Top = 264
    Width = 97
    Height = 41
    Caption = 'Pred'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = '@Arial Unicode MS'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 4
    OnClick = PredButtonClick
  end
  object SuccButton: TButton
    Left = 224
    Top = 264
    Width = 97
    Height = 41
    Caption = 'Succ'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = '@Arial Unicode MS'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 5
    OnClick = SuccButtonClick
  end
  object OrdButton: TButton
    Left = 352
    Top = 264
    Width = 97
    Height = 41
    Caption = 'Ord'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = '@Arial Unicode MS'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 6
    OnClick = OrdButtonClick
  end
  object ResetButton: TButton
    Left = 1040
    Top = 64
    Width = 121
    Height = 49
    Caption = 'Reset'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = '@Arial Unicode MS'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 7
    OnClick = ResetButtonClick
  end
end
