import csv
#with
csv_file = open('C:\My Folders Temp\students.csv', 'rb')
reader = csv.DictReaderDictReader(csv_file)
for row in reader:
    print(row['name'], row['age'])
csv_file.close()



 #   spamwriter = csv.writer(csvfile, delimiter=' ',
  #                          quotechar='|', quoting=csv.QUOTE_MINIMAL)
   # spamwriter.writerow(['Spam'] * 5 + ['Baked Beans'])
    #spamwriter.writerow(['Spam', 'Lovely Spam', 'Wonderful Spam'])