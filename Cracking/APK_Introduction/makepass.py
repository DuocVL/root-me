s = "1dndr@"

a = s[5]
_b = s[2]

lens = len(s)

for i in range(lens):

    b = _b[len(_b) - i:] + _b[i:]

    if i >= 3:
        _b2 = _b + s[i - 3]
    else:
        _b2 = _b + s[lens - (3 - i)]

    len_b2 = len(_b2)

    if i >= len_b2:
        _b = _b2 + s[i - len_b2]

    elif lens >= len_b2 - i:
        _b = _b2 + s[lens - (len_b2 - i)]

    else:
        _b = _b2 + s[lens - ((len_b2 - i) - lens)]

    a += b[(((lens + len(_b)) * i) + len(_b)) % len(b)]

password = a[0:2] + s[3] + a[3] + '0' + a[5:7]

print(f"Password: {password}")