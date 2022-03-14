.. Voting System documentation master file, created by
   sphinx-quickstart on Mon Mar 14 22:03:52 2022.
   You can adapt this file completely to your liking, but it should at least
   contain the root `toctree` directive.

Welcome to Voting System's documentation!
=========================================

.. toctree::
   :maxdepth: 3
   :caption: Contents:




Indices and tables
==================

* :ref:`genindex`
* :ref:`modindex`
* :ref:`search`


Project description
===================

This is a voting system where users can register an account to participate in votes.

To get started log into the administrator account and create a vote and some options. Once this
has been done, return to the login and enter a username and password for a new voter, click
register and a message box will appear to confirm the voter has been registered. Click login
to get to the voter form. The dropdown at the top will contain all the available votes that the
voter can participate in. The middle dropdown will contain the options for the selected vote.
Select a vote and an option, then click "Vote" to submit the vote. Each voter will only be able
to participate once in each vote.

To view the results of a vote, login as the auditor, then select the vote from the dropdown menu.
There are 2 buttons, the first will let the auditor know which option has won in the selected vote
and how many votes it had (multiple options will be displayed if there is a tie) The second button
will display the total votes for each option in the selected vote.



Default accounts
================

There are default administrator and auditor accounts as these cannot just be created by anyone.

USERNAME : PASSWORD

admin : admin

auditor : auditor


Creating votes
==============

Votes can be created when logged in as an administrator. The left side of the form has fields for
vote name, description, start date and end date. Fill out these fields and click "Add Vote".

Then go to the right side, this is where vote options can be created. Select the newly created vote
and enter the details for the first option, and click "Add Option". Repeat this process until you
have all the required options.