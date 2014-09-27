#!/usr/bin/env python2
# encoding: utf-8

lines = [[str(i * j) for i in xrange(1, 13)] for j in xrange(1, 13)]

for line in lines:
    for num in line:
        if line.index(num):
            print ' ' * (3 - len(num)) + num,
        else:
            print ' ' * (2 - len(num)) + num,
    print
