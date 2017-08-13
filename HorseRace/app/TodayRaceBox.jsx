var TodayRaceBox = React.createClass({
    loadRacesFromServer: function() {
        $.ajax({
            url: this.props.url,
            dataType: 'json',
            cache: false,
            success: function(data) {
                this.setState({data: data});
            }.bind(this),
            error: function(xhr, status, err) {
                console.error(this.props.url, status, err.toString());
            }.bind(this)
        });
    },
    getInitialState: function() {
        return {data: []};
    },
    componentDidMount: function() {
        this.loadRacesFromServer();
    },
    render: function() {
        return (
          <div>
            <h1>Races</h1>
            <RaceList data={this.state.data} />
          </div>
      );
    }
});