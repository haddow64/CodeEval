import sys
import re

POSTFIXES =  [', yeah!', ', this is crazy, I tell ya.', ', can U believe this?', ', eh?', ', aw yea.', ', yo.', '? No way!', '. Awesome!']

def main():
    inputFile = open(sys.argv[1], 'r')
    index = 0
    count = 0
    for lines in inputFile:
        lines = lines.strip()
        if len(lines) == 0:
            continue
        sentences = [x.strip() for x in re.split('[\.!\?]', lines) if len(x) > 0]
        line = []
        for s in sentences:
            if count % 2 != 0:
                line.append(s + POSTFIXES[index])
                index = (index + 1) % len(POSTFIXES)
            else:
                punctuation = lines[lines.find(s) + len(s)]
                line.append(s + punctuation)
            count += 1
        print(' '.join(line))
    inputFile.close()

if __name__ == '__main__':
    main()