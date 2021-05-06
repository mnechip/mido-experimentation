import mido
from mido import MidiFile
import numpy
from io import StringIO
import re

f=open("currentSongStr.txt", "r")
currentSongStr = f.read()
mid = MidiFile(currentSongStr) #sets midi file
f.close()

def append_new_line(file_name, text_to_append):
    """Append given text as a new line at the end of file"""
    # Open the file in append & read mode ('a+')
    with open(file_name, "a+") as file_object:
        # Move read cursor to the start of file.
        file_object.seek(0)
        # If file is not empty then append '\n'
        data = file_object.read(100)
        if len(data) > 0:
            file_object.write("\n")
        # Append text at the end of file
        file_object.write(text_to_append)

msgList = []

for i, track in enumerate(mid.tracks): #for every track in the midi, output the track message and add to msgList array
    print('Track {}: {}'.format(i, track.name))
    for msg in track:
        msgStr =str(tempo2bpm(msg))
        msgList.append(tempo2bpm(msg))
        print(msgStr)

with open("midiOutput.txt", "w") as filehandle: #writes every item in array as a new line into file
        filehandle.writelines("%s\n" % place for place in msgList)





