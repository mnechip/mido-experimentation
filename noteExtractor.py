import re
errors = []
linenum = 0
pattern = re.compile(r"note")
with open ('midiOutput.txt', 'rt') as myfile:
    