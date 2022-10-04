Feature: SFTP Testing
To verify SFTP file upload, copy, remove

@mytag
Scenario: File Upload
	Given SFTP location
	When file copied from local to SFTP as
	|localfilename|
	|C:\Users\sowjy\Dropbox\PC\Desktop\LocalFiles\sjFile.txt|
	Then File upload should be successful

@mytag
Scenario: File Remove
	Given SFTP locations
	When file removed from SFTP location
	|sftpfilename|
	|/public/sjFile.txt|
	Then File remove should be successful


@mytag
Scenario: File Download
	Given SFTP locations
	When file downloaded from SFTP location
	| sftpfilename       | downloadpath     |                                      
	| sjFile.txt | C:\Users\sowjy\Dropbox\PC\Desktop\LocalFiles\Downloads |
	Then File download should be successful

@mytag
Scenario: File Move
	Given SFTP locations
	When file moved between SFTP locations
	| sftpsrcfile | sftpdestloc |                                      
	| sjFile.txt | moved |
	Then File move should be successful

@mytag
Scenario: File Copy
	Given SFTP locations
	When file copy between SFTP locations
	| sftpsrcfile | sftpdestloc |                                      
	| sjFile.txt | private |
	Then File copy should be successful