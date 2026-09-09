key = [66, 121, 84, 51, 99, 48, 100, 51]
enc = [153, 222, 192, 159, 131, 148, 211, 161, 167, 165, 116, 167, 203, 149, 132, 153, 174, 218, 187, 83, 204, 163, 110, 117, 187, 237, 135, 150, 147, 148, 151, 118, 118, 231, 168, 133, 150, 163, 149, 166, 150]
	
hidden_content = ""
for i in range(len(enc)):
	hidden_content += chr(enc[i] - key[i % len(key)])
	
print(f"Hidden content: {hidden_content}")