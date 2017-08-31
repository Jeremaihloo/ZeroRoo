<template>
  <div id="applications">

    <ul class="nav nav-tabs" role="tablist">
      <template v-for="(tab, index) in activities">
        <li role="presentation" :class="{'active':tab.Active}" :key="index">
          <a role="tab" href="javascript:;" @click="select(activities.indexOf(tab))">
            <span v-text="tab.Activity.Title"></span>
          </a>
        </li>
      </template>
      <li class="pull-right">
        <button type="button" class="btn btn-success" @click="closeCurrentTab()">关闭</button>
      </li>
    </ul>
    <div class="tab-content">
      <div class="tab-pane" role="tabpanel" v-for="(tab, index) in activities" :class="{active:tab.Active}" :key="index" v-show="tab.Active">
        <app-activity class="app-activity" :item="tab"></app-activity>
      </div>
    </div>

  </div>
</template>

<script>
import AppActivity from './AppActivity'
import Draggable from 'vuedraggable'
// import StartDrag from '../StartDrag'

export default {
  components: {
    AppActivity,
    Draggable
  },
  data () {
    return {
      activities: [],
      drag: false,
      activeIndex: 0
    }
  },
  watch: {
    activeIndex: function (val, oldVal) {
      // console.log('tabIndex changed', val, oldVal)
    }
  },
  created () {
    if (this.activities.length === 0) {
      let welcome = {
        Activity: {
          Title: '欢迎'
        },
        Target: 'http://wwww.baidu.com'
      }
      this.activities.push(welcome)
      this.select(this.activities.length - 1)
    }
    this.$engine.subscribe('ZeroRoo.DefaultApp.Services.Open', msg => {
      console.log('ActivitiesContainer $engine.subscribe', 'ZeroRoo.DefaultApp.Services.Open', msg)
      let activityItem = msg.Data
      console.log(this.activities, activityItem)
      var find = this.activities.filter(item => {
        return item.Target === activityItem.Target
      })
      // console.log('find', find)
      if (find.length === 0) {
        this.activities.push(activityItem)
        // console.log('activity:open callback', activityItem)
        this.select(this.activities.length - 1)
      } else {
        this.select(this.activities.indexOf(find[0]))
      }
    })
    this.$engine.subscribe('ZeroRoo.DefaultApp.Services.ActivityTitleChange', msg => {
      console.log('ActivityTitleChange', msg)
      this.activities.forEach(function (element) {
        if (element.Activity.Name === msg.Data.Item.Activity.Name) {
          console.log('命中----------------------------')
          element.Activity.Title = msg.Data.NewTitle
        }
      }, this)
    })
  },
  mounted () {

  },
  methods: {
    selectCurrent () {
      this.activities.forEach(tab => {
        tab.Active = false
      })
      this.activities[this.activeIndex].Active = true
      this.activities = Object.assign([], this.activities)
      console.log('[ActivitiesPanel:SELECT_CURRENT_TAB]', this.activeIndex, this.activities)
    },
    select (index) {
      // console.log('onSelect', index)
      this.activeIndex = index
      this.selectCurrent()
    },
    closeCurrentTab () {
      if (this.activeIndex === 0) {
        return
      }
      let s = []
      for (var index = 0; index < this.activities.length; index++) {
        if (index !== this.activeIndex) {
          s.push(this.activities[index])
        }
      }
      this.activities = Object.assign([], s)
      this.select(0)
    }
  }
}
</script>

<style lang="stylus" scoped>
#applications 
  display flex
  flex-direction column
  div, section
    display flex
    width 100%    
    flex 1
</style>

