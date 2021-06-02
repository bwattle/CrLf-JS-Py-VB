from ast import literal_eval
# wipe this and add your code below
msg1 = 'Message 1 - no apostrphe';
msg2 = "Message 2 - You didn't win"; # double quotes
msg3 = 'Message 3 - You didn\'t win'; # backslash preceding apostrophe
msg4 = 'this is message 4'
print('1st print joins with +: '+ msg1 + ', '+ msg2 + ', '+ msg3)
print('2nd print joins with commas:', msg1, ', ', msg2, ', ', msg3)
print('3rd print uses backslash n for new line: '+ msg1 + '\n' + msg2)
print('4th print uses backslash n with spaces for indents: '+ msg1 + '\n    ' + msg2 + '\n    ' + msg3 + '\n    ' + msg4)
print('5th print uses backslash r for carriage return - it overwrites: '+ msg1 + '\r' + msg2)
# print("This print has the messages on new lines ", msg1\nmsg2)