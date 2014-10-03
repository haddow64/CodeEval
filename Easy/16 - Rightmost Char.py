import sys

def rightmost_char(line):
    s, t = line.rstrip().split(',')
    return s.rfind(t)
 
def main():
    with open(sys.argv[1], 'r') as f:
        for line in f:
            print(rightmost_char(line))
 
if __name__ == '__main__':
    main()