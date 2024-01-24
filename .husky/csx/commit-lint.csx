using System.Text.RegularExpressions;

private var pattern = @"^\[\d+\] (?:build|feat|ci|chore|docs|fix|perf|refactor|revert|style|test): .*$";
private var msg = File.ReadAllLines(Args[0])[0];

if (Regex.IsMatch(msg, pattern))
{
  Console.WriteLine("Valid message!");
  return 0;
}


Console.WriteLine("Invalid commit message");
Console.WriteLine("exp: [Kanban number] [prefix]: example commit message.");
Console.WriteLine("Prefix: build|feat|ci|chore|docs|fix|perf|refactor|revert|style|test");
return 1;
