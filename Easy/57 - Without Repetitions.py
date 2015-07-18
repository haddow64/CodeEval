import sys

def WithoutRepetitions(lines):
    if len(lines) == 0: return lines
    result = [lines[0]]
    for char in lines[1:]:
        if char != result[-1]:
            result.append(char)
    return ''.join(result)

def main():
    inputFile = open(sys.argv[1], 'r')
    for lines in inputFile:
        lines = lines.strip()
        if len(lines) == 0:
            continue
        print(WithoutRepetitions(lines))
    inputFile.close()

if __name__ == '__main__':
    main()