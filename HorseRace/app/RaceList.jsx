var RaceList = React.createClass({
    render: function() {
        var raceNodes = this.props.data.map(function(race) {
            return (
                <Race key={race.Id} Name={race.Name} TotalBetAmount={race.TotalBetAmount} RaceFinished={race.RaceFinished} Horses={race.Horses} />
            );
    });
    return (
        <div>
            <table className="Races">
                <thead>
                    <tr>
                        <th> Race Name </th>
                        <th> Total Bet Amount </th>
                        <th> Race Finished? </th>
                        <th> Horses </th>
                    </tr>
                </thead>
                <tbody>
                    {raceNodes}
                </ tbody>
            </table>
        </div>
        );
    }
});