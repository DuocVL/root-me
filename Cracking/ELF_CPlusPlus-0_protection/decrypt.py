hex1=bytes.fromhex("18d615cafa77")
hex2=bytes.fromhex("50b367afa50e77a34aa29b017d8961a5a50276b270b8890379b871959b2874bf61be961247953ee1a5046ca373ac89")

password = ""
len1 = len(hex1)
len2 = len(hex2)
print(f"Chuỗi 1: {hex1} {len1}") 
print(f"Chuỗi 2: {hex2} {len2}")
for i in range(0,len2):
    password += chr(hex1[i % len1] ^ hex2[i])


print(f"Password: {password}") 