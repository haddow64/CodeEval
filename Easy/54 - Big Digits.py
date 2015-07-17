import sys

inputFile = open(sys.argv[1], 'r')

bigDigits = [
    # 0
    ['-**-', '*--*', '*--*', '*--*', '-**-'],
    # 1
    ['--*-', '-**-', '--*-', '--*-', '-***'],
    # 2
    ['***-', '---*', '-**-', '*---', '****'],
    # 3
    ['***-', '---*', '-**-', '---*', '***-'],
    # 4
    ['-*--', '*--*', '****', '---*', '---*'],
    # 5
    ['****', '*---', '***-', '---*', '***-'],
    # 6
    ['-**-', '*---', '***-', '*--*', '-**-'],
    # 7
    ['****', '---*', '--*-', '-*--', '-*--'],
    # 8
    ['-**-', '*--*', '-**-', '*--*', '-**-'],
    # 9
    ['-**-', '*--*', '-***', '---*', '-**-']
]

for digit in inputFile:
    digit = digit.strip()
    if len(digit) == 0: continue
    digits = []
    for t in digit:
        if t.isdigit(): digits.append(int(t))

    for line in range(0, 5):
        for d in digits:
            sys.stdout.write(bigDigits[d][line])
            sys.stdout.write('-')
        print()
    print('-----' * len(digits))

inputFile.close()