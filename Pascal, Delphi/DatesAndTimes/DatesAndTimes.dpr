program DatesAndTimes;

{$APPTYPE CONSOLE}

uses
  SysUtils;

var
  MyDateTime, MyBirthDay: TDateTime;
  Format: string;

begin
  MyDateTime := Now;
  Format := FormatDateTime('yyyy-mm-dd hh:nn:ss', MyDateTime);
  WriteLn('The current date and time is: ' + Format);
  MyDateTime := Date;
  Format := FormatDateTime('yyyy-mm-dd', MyDateTime);
  WriteLn('The current date is: ' + Format);
  MyDateTime := Time;
  Format := FormatDateTime('hh:nn:ss', MyDateTime);
  WriteLn('The current time is: ' + Format);
  MyBirthDay := EncodeDate(1985, 1, 30) + EncodeTime(21, 50, 00, 000);
  Format := FormatDateTime('yyyy/mm/dd hh:nn', MyBirthDay);
  WriteLn('My name is Hristifor Sotirovski. My birthday is: ' + Format);
  Readln;
end.
 