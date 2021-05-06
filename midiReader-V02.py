import mido
from mido import MidiFile
import numpy
from io import StringIO
import re

mid = MidiFile('Aragami.mid') #sets midi file

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
        msgStr =str(msg)
        msgList.append(msg)
        print(msgStr)

strMsgList = str(msgList) #converts array to string
print(strMsgList)
f=open("midiOutput.txt", "r")
f.write(strMsgList, sep = "\n")





