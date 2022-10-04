Feature: SFTP Testing
To verify SFTP file upload, copy, remove

@mytag
Scenario: File Upload
	Given SFTP location
	When file copied from local to SFTP as
	|filename|
	|C:\Users\sowjy\Dropbox\PC\Desktop\LocalFiles\sjFile.txt|
	Then File upload should be successful

@mytag
Scenario: File Remove
	Given SFTP locations
	When file removed from SFTP location
	|filename|
	|C:\Users\sowjy\Dropbox\PC\Desktop\LocalFiles\sjFile.txt|
	Then File remove should be successful