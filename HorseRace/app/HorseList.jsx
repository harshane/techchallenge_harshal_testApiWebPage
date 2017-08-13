var HorseList = React.createClass({
    render: function() {
        var horseNodes = this.props.data.map(function(horse) {
            return (
                <Horse key={horse.Id} Name={horse.Name} NumberOfBets={horse.NumberOfBets} WinningAmount={horse.WinningAmount} />
            );
    });
    return (
        <table className="Horses">
                <tbody>
                    {horseNodes}
                </ tbody>
            </table>
        );
    }
});