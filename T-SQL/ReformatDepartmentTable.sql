USE TSQL;

CREATE TABLE #Department (
    id INT, revenue INT, month varchar(3)
);
GO
INSERT INTO #Department VALUES (1, 8000, 'Jan');
INSERT INTO #Department VALUES (2, 9000, 'Jan');
INSERT INTO #Department VALUES (3, 10000, 'Feb');
INSERT INTO #Department VALUES (1, 7000, 'Feb');
INSERT INTO #Department VALUES (1, 6000, 'Mar');
GO

SELECT id, Jan AS Jan_Revenue, Feb AS Feb_Revenue, Mar AS Mar_Revenue,
				  Apr AS Apr_Revenue, May AS May_Revenue, Jun AS Jun_Revenue,
				  Jul AS Jul_Revenue, Aug AS Aug_Revenue, Sep AS Sep_Revenue,
				  Oct AS Oct_Revenue, Nov AS Nov_Revenue, Dec AS Dec_Revenue
			 
	FROM 
	(SELECT * FROM #Department GROUP BY month, id, revenue) AS D
PIVOT(SUM(revenue) FOR month IN (Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec)) AS pivot_table;

DROP TABLE #Department;